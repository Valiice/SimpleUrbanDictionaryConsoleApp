using Cons.Jonkos;
using System.Text.Json;

namespace UrbanDictionary.Cons
{
    internal class Program
    {
        string token = "";
        public Program()
        {
            token = Environment.GetEnvironmentVariable("UrbanDictionaryKey");
        }
        static void Main(string[] args)
        {
            new Program().Run().Wait();
        }
        private async Task Run()
        {
            Console.Write("Enter a word: ");
            var searchWord = Console.ReadLine();
            Console.Write("\n\n");
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://mashape-community-urban-dictionary.p.rapidapi.com/");
            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", token);
            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "mashape-community-urban-dictionary.p.rapidapi.com");
            using (var response = await httpClient.GetAsync($"define?term={searchWord}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStreamAsync();

                    var wordList = await JsonSerializer.DeserializeAsync<Root>(responseStream);
                    var orderedList = wordList.List.OrderByDescending(c => c.ThumbsUp).ToList();
                    foreach (UrbanDictionaryWord word in orderedList)
                    {
                        if (word.Word.ToUpper() == searchWord.ToUpper())
                        {
                            Console.WriteLine($"{word.Definition}\n\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}