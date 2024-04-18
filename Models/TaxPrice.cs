using System.Text.Json.Serialization;

namespace AutoComplete_App.Models
{
    public class TaxPrice
    {
        private string code;
        private int tax;

        [JsonPropertyName("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        [JsonPropertyName("tax")]
        public int Tax
        {
            get { return tax; }
            set { tax = value; }
        }
    }
}
