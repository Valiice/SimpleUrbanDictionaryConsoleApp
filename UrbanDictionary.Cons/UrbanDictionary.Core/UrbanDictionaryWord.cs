using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cons.Jonkos
{
    public class UrbanDictionaryWord
    {
        [JsonPropertyName("definition")]
        public string Definition { get; set; }
        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }
        [JsonPropertyName("thumbs_up")]
        public int ThumbsUp { get; set; }
        [JsonPropertyName("sound_urls")]
        public List<string> SoundUrls { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("word")]
        public string Word { get; set; }
        [JsonPropertyName("defid")]
        public int Defid { get; set; }
        [JsonPropertyName("current_vote")]
        public string CurrentVote { get; set; }
        [JsonPropertyName("written_on")]
        public DateTime WrittenOn { get; set; }
        [JsonPropertyName("example")]
        public string Example { get; set; }
        [JsonPropertyName("thumbs_down")]
        public int ThumbsDown { get; set; }
    }
}
