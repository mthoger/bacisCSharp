using System;

namespace opgave50x
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tælle fra 0 til 9 og udskrive tal
            for (int i = 0; i < 10; i++)
            {
                if( i%2 != 0 )
                Console.WriteLine(i);
            }

            //tælle fra 1 til 20 men kun hver anden (1-3-5-7...). Udskriv tal
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }

            //Tælle fra 1 til 20 og udskriv tal - men lige tal skal være gule og ulige tal røde
            for (int i = 0; i < 20; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (i % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                    Console.WriteLine(i);

                
            }
            for (int y = 1; y < 11; y++)
            {
                for (int x = 1; x < 11; x++)
                {
                    string tal = (x * y).ToString();
                    if (x * y > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }
}
