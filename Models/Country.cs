using System.Text.Json.Serialization;

namespace AutoComplete_App.Models
{
    public class Country
    {
        private string name;
        private string code;

        [JsonPropertyName("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [JsonPropertyName("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
