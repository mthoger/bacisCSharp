using System;
using System.Collections.Generic;
using System.Linq;

namespace _150_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Faktura.HentFakturaer();
            res.ForEach(x => Console.WriteLine(x));


            Console.WriteLine();
            res.OrderBy(f => f.Kunde).ToList().ForEach(f => Console.WriteLine(f));

            Console.WriteLine();
            res.OrderBy(f => f.Kunde).ToList().ForEach(f => Console.WriteLine(f));

            Console.WriteLine();
            res.OrderBy(f => f.Dato).ToList().ForEach(f => Console.WriteLine(f));

            Console.WriteLine();
            res.Where(f => f.Region == "Fyn").OrderBy(f => f.Dato).ToList().ForEach(f => Console.WriteLine(f));

            Console.WriteLine();
            int count = res.Where(f => f.Region == "Fyn").ToList().Count();
            Console.WriteLine(count.ToString());

            // Samlaet salgs sum 
            Console.WriteLine();
            Console.WriteLine(res.Sum(f => f.Salg).ToString("N2"));

            // Samlet salg på Fyn
            Console.WriteLine();
            Console.WriteLine(res.Where(i => i.Region == "Fyn").Sum(f => f.Salg).ToString("N2"));
        }
    }

    class Faktura
    {

        public DateTime Dato { get; set; }
        public int Nummer { get; set; }
        public string Kunde { get; set; }
        public string Region { get; set; }
        public double Salg { get; set; }

        public static List<Faktura> HentFakturaer()
        {

            List<Faktura> lst = new List<Faktura> {
            new Faktura{ Dato = new DateTime(2020,7,1), Nummer = 1, Kunde ="Jens", Region = "Fyn", Salg = 100 },
            new Faktura{ Dato = new DateTime(2020,5,1), Nummer = 2, Kunde ="Anders", Region = "Fyn", Salg = 300 },
            new Faktura{ Dato = new DateTime(2021,1,1), Nummer = 3, Kunde ="Mette", Region = "Sjælland", Salg = 150 },
            new Faktura{ Dato = new DateTime(2020,12,1), Nummer = 4, Kunde ="Hans", Region = "Jylland", Salg = 900 },
        };
            return lst;
        }

        public override string ToString()
        {
            return $"{Dato.ToShortDateString()} {Nummer} {Kunde} ({Region})";
        }
    }
}
