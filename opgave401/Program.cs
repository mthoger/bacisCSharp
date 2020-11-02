using System;
using System.IO;

namespace opgave401
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Indtast et heltal");
            //int helTal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"indtastet heltal er {helTal}");
            //helTal++;
            //Console.WriteLine($"heltal inc er {helTal}");
            //helTal--;
            //Console.WriteLine($"heltal dec er {helTal}");
            //Console.WriteLine("Indtast et kommatal");
            //double kommanTal = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(kommanTal);
            //kommanTal++;
            //Console.WriteLine(kommanTal);
            //kommanTal--;
            //Console.WriteLine(kommanTal);
            //kommanTal *= 2;
            //Console.WriteLine($"kommanTal er {kommanTal}");

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            if (System.IO.Directory.Exists("c:\\temp"))
                {
                Console.WriteLine("directory exist, writing to file.");
                System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            }
            else
            {
                Console.WriteLine("directory does not exist, creating it now");
                Directory.CreateDirectory("c:\\temp");
                Console.WriteLine("directory created, now writing to file");
                System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            }
                string samletNavn2 = $"{fornavn} {efternavn}";

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
