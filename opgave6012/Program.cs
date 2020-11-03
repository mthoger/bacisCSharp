using System;
using System.IO;

namespace opgave6012
{
    class Program
    {
        static void Main(string[] args)
        {
            //int res = LægSammen(5, 2);
            //Console.WriteLine($"Sum {res}");

            //double res2 = BeregnAreal(5);
            //Console.WriteLine($"Areal {res2}");

            //double res3 = BeregnBeløbefterMoms(100, .25);
            //Console.WriteLine($"Beløb Efter Moms {res3}"); int res = LægSammen(5, 2);
            //Console.WriteLine($"Sum {res}");

            //double res2 = BeregnAreal(5);
            //Console.WriteLine($"Areal {res2}");

            //double res3 = BeregnBeløbefterMoms(100, .25);
            //Console.WriteLine($"Beløb Efter Moms {res3}");

            if (File.Exists("C:\\temp\\test.txt"))
            {
                Console.WriteLine("filen findes");
                string text = File.ReadAllText("C:\\temp\\test.txt");
                Console.WriteLine(text);
                FileInfo P = new FileInfo("C:\\temp\\test.txt");
                DateTime dateTime = P.LastAccessTime;
                Console.WriteLine($"Tid: {dateTime}");
                string ex = P.Extension;
                Console.WriteLine($"Extension: {ex}");
            }


        }

        static int LægSammen(int a, int b)
        {
            return (a + b);
        }

        static double BeregnAreal(Double a)
        {
            return ((a * a) * 3.14);
        }

        static double BeregnBeløbefterMoms(double a, double b)
        {
            return (a * (1 + b));
        }
    }
}
