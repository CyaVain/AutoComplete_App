using System.Text.Json.Serialization;

namespace AutoComplete_App.Models
{
    public class Inventory
    {
        private string code;
        private string category;

        [JsonPropertyName("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        [JsonPropertyName("category")]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
