using System;
using System.Collections.Generic;

namespace lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine("function");
            Console.WriteLine(a.FindIndex(FindIndex));
            Console.WriteLine("lamba");
            Console.WriteLine(a.FindIndex( x => x== 51));
            Console.WriteLine("function");
            a.ForEach(ListVærdi);
            Console.WriteLine("lamba");
            a.ForEach(x => Console.WriteLine(x));
        }
        static bool FindIndex(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }

    
}
