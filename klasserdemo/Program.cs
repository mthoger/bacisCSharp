using System;

namespace klasserdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1 = new Terning();
            //System.Console.WriteLine(t1.værdi);
            //t1.Ryst();
            //System.Console.WriteLine(t1.værdi);
            //Terning t3 = new Terning(8);

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

        }
    }

}

