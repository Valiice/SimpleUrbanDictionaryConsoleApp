using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cons.Jonkos
{
    public class Root
    {
        [JsonPropertyName("list")]
        public List<UrbanDictionaryWord> List { get; set; }
    }
}
