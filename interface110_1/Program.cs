using System;
using System.Collections.Generic;

namespace interface110_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDbFunktioner> array = new List<IDbFunktioner>
            {
               new Hund { Navn = "Henning" },
               new Ubåd { Nummer = 23 }
        };

            foreach (IDbFunktioner item in array)
            {
                item.gem();
            }
        }
    }

    class Hund : IDbFunktioner
    {

        public string Navn { get; set; }

        public void gem()
        {
            Console.WriteLine(" Gemmer hund");
        }
    }

    class Ubåd : IDbFunktioner
    {

        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void gem()
        {
            Console.WriteLine(" Gemmer Ubåd.....");
        }
    }

    interface IDbFunktioner
    {
        void gem();

    }
}
