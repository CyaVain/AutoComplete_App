using System.Text.Json.Serialization;

namespace AutoComplete_App.Models
{
    public class SeaPort
    {
        private string name;
        private string country;

        [JsonPropertyName("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonPropertyName("country")]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
