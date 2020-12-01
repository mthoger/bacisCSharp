using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace http
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await httpClient.GetAsync("https://dawa.aws.dk/Regioner");
            if (response.IsSuccessStatusCode)
            {
                List<Region> Regions = await response.Content.ReadAsAsync<List<Region>>();
                Regions.ForEach(i => Console.WriteLine($"{i.Kode} {i.Navn}"));
                
            }
        }
    }
    class Region
    {
        public string Navn { get; set; }
        public string Kode { get; set; }
    }
}
