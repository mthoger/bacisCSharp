﻿using System;

namespace advancedTerningArv
{
    class Program
    {
        static void Main(string[] args)
        {
            LudoTerning l = new LudoTerning();
            for (int i = 0; i < 10; i++)
            {
                l.Ryst();
                l.Skriv();
            }
            
            
        }
    }

    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                //Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }
    }

    sealed public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (this.Værdi == 3)
            {
                return true;
            }
            return false;

        }

        public bool ErStjerne()
        {
            if (this.Værdi == 5)
            {
                return true;
            }
            return false;
        }

        public override void Skriv()
        {
            if(this.ErGlobus())
            {
                Console.WriteLine("[G]");
            }
            else if(this.ErStjerne())
            {
                Console.WriteLine("[S]");
            }
            else
            {
                base.Skriv();
            }
        }
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base(værdi)
        {

        }
    }
}
