using System;


namespace yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bæger b = new Bæger();
        }
    }

    public class Bæger
    {
        private Terning[] dices = new Terning[5];
        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i] = new Terning();
                dices[i].Ryst();
                dices[i].Skriv();
            }

        }
    }
    public class Terning
    {
        // Ved .NET Core behøver den ikke være statisk!!
        private static Random rnd = new Random();
        public int værdi;

        public Terning()
        {
            this.værdi = 1;
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }

}
