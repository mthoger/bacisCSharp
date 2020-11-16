using System;

namespace autopropsTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning T1 = new Terning();
            T1.Skriv();
            T1.Ryst();
            T1.Skriv();

            Terning T2 = new Terning(6);
            T2.Skriv();
            T2.Ryst();
            T2.Skriv();
        }
    }

    class Terning
    {
        public int Værdi { get; private set; }

        public void Ryst()
        {
            System.Random rnd = new System.Random();
            Værdi = rnd.Next(1, 7);
        }
        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int nr)
        {
            if (nr < 1 || nr > 6)
            {
                Console.WriteLine("værdi er forkert - skal være mellem 1 og 6 ");
                throw new ArgumentException("Forkert værdi");
            }
            Værdi = nr;
        }
    }
}
