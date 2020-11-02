using System;

namespace opgave401
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast et heltal");
            int helTal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"indtastet heltal er {helTal}");
            helTal++;
            Console.WriteLine($"heltal inc er {helTal}");
            helTal--;
            Console.WriteLine($"heltal dec er {helTal}");
            Console.WriteLine("Indtast et kommatal");
            double kommanTal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(kommanTal);
            kommanTal++;
            Console.WriteLine(kommanTal);
            kommanTal--;
            Console.WriteLine(kommanTal);
            kommanTal *= 2;
            Console.WriteLine($"kommanTal er {kommanTal}");
        }
    }
}
