using System;
using System.Text.Json;

namespace poly1_501
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura F = new Faktura { nr = 1, dato = DateTime.Now, kunde = "michael" };
            Console.WriteLine(F.ToString());
        }
    }

    class Faktura
    {
        public int nr { get; set; }
        public DateTime dato { get; set; }
        public string kunde { get; set; }

        public override string ToString()
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(this);
            return jsonString;
        }
    }
}
