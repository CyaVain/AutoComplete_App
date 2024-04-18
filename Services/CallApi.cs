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
        
        static string fileOutput = @"..\\AutoComplete_App\\countries.json";

        public Country[] Countries { get; private set; }

        public CallApi(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task GetCountryList()
        {
            string url = "https://gist.githubusercontent.com/almost/7748738/raw/575f851d945e2a9e6859fb2308e95a3697bea115/countries.json";
            var response = await client.GetStringAsync(url);

            File.WriteAllText(fileOutput, response);

            await ReadCountry();
        }

        public async Task ReadCountry()
        {
            string json = File.ReadAllText(fileOutput);
            Countries = JsonSerializer.Deserialize<Country[]>(json);
        }
    }
}
