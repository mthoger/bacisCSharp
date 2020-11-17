﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv_polymorfi_dyr
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund() { Navn = "a" };
            h.SigNoget();
            Kat k = new Kat() { Navn = "b" }; ;
            k.SigNoget();
            Dyr d = new Kat() { Navn = "c" }; ;
            d.SigNoget();
            Console.WriteLine();
            List<Dyr> forskelligeDyr = new List<Dyr>() { d, h, k, new Hund() { Navn = "c" }, new Kat() { Navn = "d" }, new Kat() { Navn = "henning" } };
            foreach (Dyr item in forskelligeDyr)
            {
                item.SigNoget();
            }
            Console.WriteLine();

            Dyr[] dyr = new Dyr[100];
            for (int i = 0; i < 100; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }
        }
    }

    abstract class Dyr
    {

        static System.Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }

        public static Dyr TilfældigtDyr()
        {

            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';'); int index = rnd.Next(0, navne.Length);
            if (index % 3 <= 1)
            {
                return new Hund() { Navn = navne[index] };
            }
            else if( index % 3 > 2 && index % 3 <= 2 )
            {
                return new Kat() { Navn = navne[index] };
            }
            else
            {
                return new hest() { Navn = navne[index] };
            }

        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }

    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }

    class hest : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hest og hedder " + Navn);
        }
    }
}