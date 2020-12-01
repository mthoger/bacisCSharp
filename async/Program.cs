using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace async_primtal
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main start");
            await Run2(60000);
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.Write(i.ToString("00" + " "));
            }
            Console.WriteLine("Main slut");
        }

        static void Run1(int antal)
        {
            Console.WriteLine("Run1 start");
            var res1 = FindPrimtal1(antal);
            Console.WriteLine($"\nAntal fundet: {res1.Count}");
            Console.WriteLine("\nRun1 slut");
        }

        public static List<int> FindPrimtal1(int tilVærdi)
        {
            Console.WriteLine("FindPrimtal1 start");
            List<int> primes = new List<int>();
            bool isPrime = true;
            for (int i = 2; i <= tilVærdi; i++)
            {
                for (int j = 2; j <= tilVærdi; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
                isPrime = true;
            }
            Console.WriteLine("FindPrimtal1 slut");
            return primes;
        }

        static async Task Run2(int antal)
        {
            Console.WriteLine("Run2 start");
            var res1 = await FindPrimtal2(antal);
            Console.WriteLine($"\nAntal fundet: {res1.Count}");
            Console.WriteLine("\nRun2 slut");
        }

        public static Task<List<int>> FindPrimtal2(int tilVærdi)
        {
            Console.WriteLine("FindPrimtal2 start");
            Task<List<int>> t = new Task<List<int>>(() =>
            {
                List<int> primes = new List<int>();
                bool isPrime = true;
                for (int i = 2; i <= tilVærdi; i++)
                {
                    for (int j = 2; j <= tilVærdi; j++)
                    {
                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primes.Add(i);
                    }
                    isPrime = true;
                }
                return primes;
            });
            t.Start();
            Console.WriteLine("FindPrimtal2 slut");
            return t;
        }
    }
}