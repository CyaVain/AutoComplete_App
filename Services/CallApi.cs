using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using AutoComplete_App.Models;

namespace AutoComplete_App.Services
{
    public class CallApi
    {
        readonly HttpClient client;
        
        static string countryFile = @"..\\AutoComplete_App\\Data\\countries.json";
        static string portFile = @"..\\AutoComplete_App\\Data\\seaports.json";
        static string inventoryFile = @"..\\AutoComplete_App\\Data\\inventory.json";
        static string taxFile = @"..\\AutoComplete_App\\Data\\taxes.json";

        public Country[] Countries { get; private set; }
        public SeaPort[] Ports { get; private set; }
        public Inventory[] Inventories { get; private set; }
        public TaxPrice[] TaxPrices { get; private set; }

        public CallApi(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task GetCountryList()
        {
            string url = "https://gist.githubusercontent.com/almost/7748738/raw/575f851d945e2a9e6859fb2308e95a3697bea115/countries.json";
            var response = await client.GetStringAsync(url);

            File.WriteAllText(countryFile, response);
        }
        public void ReadCountry()
        {
            string json = File.ReadAllText(countryFile);
            Countries = JsonSerializer.Deserialize<Country[]>(json);
        }

        public void ReadPortList()
        {
            string json = File.ReadAllText(portFile);
            Ports = JsonSerializer.Deserialize<SeaPort[]>(json);
        }
        public void ReadInventoryList()
        {
            var json = File.ReadAllText(inventoryFile);
            Inventories = JsonSerializer.Deserialize<Inventory[]>(json);
        }
        public void ReadTaxList()
        {
            var json = File.ReadAllText(taxFile);
            TaxPrices = JsonSerializer.Deserialize<TaxPrice[]>(json);
        }
    }
}
