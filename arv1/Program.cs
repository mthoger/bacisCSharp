using System;

namespace arv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Console.WriteLine("indtast fornavn");
            P1._fornavn = Console.ReadLine();
            Console.WriteLine("indtast efternavn");
            P1._efternavn = Console.ReadLine();
            P1.Fuldtnavn();

            arv1.Elev P2 = new Elev();
            Console.WriteLine("indtast fornavn");
            P2._fornavn = Console.ReadLine();
            Console.WriteLine("indtast efternavn");
            P2._efternavn = Console.ReadLine();
            P2.Fuldtnavn();
            Console.WriteLine("indtast klasselokae for elev");
            P2._klasselokale = Console.ReadLine();
            Console.WriteLine($"elevs klasselokale er : {P2._klasselokale}");

        }
    }

    class Person
    {
        public string _fornavn { get; set; }
        public string _efternavn { get; set; }

        public void Fuldtnavn()
        {
            Console.WriteLine($"Det fulde navn er : {this._fornavn} {this._efternavn}");
           
        }

        

       
    }
    class Elev : Person
        {
            public string _klasselokale { get; set; }
}
    class Inskruktør : Person
    {
        public int _nøgleid { get; set; }
    }
}
