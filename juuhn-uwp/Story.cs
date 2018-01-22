using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juuhn_uwp
{
    public class Story
    {
        [JsonProperty(PropertyName = "by")]
        public string By { get; set; }
        [JsonProperty(PropertyName = "descendants")]
        public int Descendants { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "kids")]
        public List<int> Kids { get; set; }
        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string URL { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
