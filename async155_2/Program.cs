using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace async155_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient w = new HttpClient();
            Console.WriteLine("Henter tal");
            string b = await w.GetStringAsync(@"https://www.random.org/integers/?num=1&min=10&max=100&col=1&base=10&format=plain&rnd=new");
            Console.WriteLine("Tal hentet");
            await System.IO.File.AppendAllTextAsync(@"c:\temp\tal.txt", b);
            Console.WriteLine("Tal gemt");
        }
    }
}
