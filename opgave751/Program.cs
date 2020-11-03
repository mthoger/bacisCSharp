using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace opgave751
{
    class Program
    {
        static void Main(string[] args)
        {
            // opgave7511
            //int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            //int sum = Udregning(månedsløn);
            //int gns = (sum / månedsløn.Length);
            //Console.WriteLine($"gennemsnitlig løn: {gns}");

            // opgave 7512
            //string[,] navne = new string[4, 2];
            //navne[0, 0] = "1";
            //navne[0, 1] = "Navn1";
            //navne[1, 0] = "2";
            //navne[1, 1] = "Navn2";
            //navne[2, 0] = "3";
            //navne[2, 1] = "Navn3";
            //navne[3, 0] = "4";
            //navne[3, 1] = "Navn4";
            //Console.WriteLine(FindNavn(navne, "2"));

            // opgave 7513
            string txt = "3;5;22;1;10;15;5";
            string[] array = txt.Split(";");
            int sum = Udregning(array, true);
            int gns = (sum / array.Length);
            Console.WriteLine($"gennemsnitlig løn: {gns}");

        }


        static string FindNavn(string[,] array, string id)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] == id)
                    return array[i, 1];
            }
            return "?";
        }

        static int Udregning(int[] a)
        {
            int sum = 0;
            foreach (int item in a)
            {
                Console.WriteLine(item);
                sum += item;

            }
            return sum;
        }

        static int Udregning(string[] a, bool convert)
        {
            int sum = 0;
            foreach (string item in a)
            {
                
                Console.WriteLine(item);
                sum += Convert.ToInt32(item);

            }
            return sum;
        }
    }



}

