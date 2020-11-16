using System;

namespace klasserdemo
{
    class Terning
    {
        public int værdi;
        private bool snyd;

        public void Ryst()
        {
            if (!snyd)
            {
                System.Random rnd = new System.Random();
                int tal = rnd.Next(1, 7);
                this.værdi = tal;
            }
            else
            {
                this.værdi = 6;
            }

        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.værdi}]");
        }

        //Defualt contructer 
        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;

            if (værdi < 1 || værdi > 6 )
            {
                Console.WriteLine("værdi er forkert - skal være mellem 1 og 6 ");   
                throw new ArgumentException ("Forkert værdi");
            }
           
        }
    }

}

