using System;

namespace opgave481
{
    class Program
    {
        static void Main(string[] args)
        {
            int kort1Værdi = 2;
            KortKulør kort1Kulør = KortKulør.Hjerter;
            Console.WriteLine($"{kort1Kulør.ToString()} {kort1Værdi}");
            Console.WriteLine($"{Convert.ToInt32(kort1Kulør)} {kort1Værdi}");


            int kort2Værdi = 2;
            KortKulør kort2Kulør = KortKulør.Ruder;
            Console.WriteLine($"{kort2Kulør.ToString()} {kort2Værdi}");
            Console.WriteLine($"{Convert.ToInt32(kort2Kulør)} {kort2Værdi}");



        }

        internal enum KortKulør
        {
            Spar,
            Hjerter,
            Ruder,
            Klør
        }
    }
}
