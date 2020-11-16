using System;

namespace automatiskEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Console.WriteLine("indtast fornavn");
            P1.fornavn = Console.ReadLine(); 
            Console.WriteLine("indtast efternavn");
            P1.EfterNavn = Console.ReadLine();
            P1.Fuldtnavn();
        }
    }

    class Person
    {
        public string fornavn { get; set; }
        private string _efternavn;


        public string EfterNavn
        {
            get { return _efternavn; }
            set { 
                if (value.Length <= 3)
                {
                    value = "";
                }
                _efternavn = value; }
        }
        public void Fuldtnavn()
        {
            Console.WriteLine($"Det fulde navn er : {this.fornavn} {this.EfterNavn}" );
        }

    }
}
