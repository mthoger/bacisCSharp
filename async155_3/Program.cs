using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace async155_3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start");
            HttpClient w = new HttpClient();
            string users = await w.GetStringAsync(@"http://www.filltext.com/?rows=10&id={index}&brugernavn={username}&password={randomString|5}");
            List<Bruger> Brugere = System.Text.Json.JsonSerializer.Deserialize<List<Bruger>>(users);
            foreach (var bruger in Brugere)
                Console.WriteLine($"{bruger.id} {bruger.brugernavn} {bruger.password}");
            Console.WriteLine("Slut");
        }
    }

    class Bruger
    {
        public string brugernavn { get; set; }
        public int id { get; set; }
        public string password { get; set; }
    }
}
