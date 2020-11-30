using System;

namespace kreditmax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast navn");
            string Navn = Console.ReadLine();
            Console.WriteLine("INDTAST START SALDO");
            int Saldo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Indtast kredit");
            int KreditMax = Int32.Parse(Console.ReadLine());

            Kunde k = new Kunde() { Navn=Navn, Saldo=Saldo, KreditMax = KreditMax };
            k.KreditOverskredet += (s, e) => {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(600);	// Her skal metoden bundet
        }
    }
    public class Kunde
    {
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                KreditOverskredet?.Invoke(this, new EventArgs());  
            }
        }
    }
}
