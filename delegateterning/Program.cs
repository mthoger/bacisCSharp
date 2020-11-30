using System;

// Func
// return somthing 
// action
// return void 
//predicate 
// return bool.



namespace delegateterning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.TilfældigTalFunktion = new TilfældigTakDelegate(FT);
            t.Ryst();
            Console.WriteLine(t.Værdi);
        }
        public static int FT()
        {
            return new Random().Next(1, 7);
        }
    }

    public delegate int TilfældigTakDelegate();

    class Terning
    {
        public int Værdi { get; set; }
        public TilfældigTakDelegate TilfældigTalFunktion { get; set; }
        public void Ryst()
        {
            this.Værdi = FindTal();
        }
        public int FindTal()
        {
            if(TilfældigTalFunktion!= null)
               return TilfældigTalFunktion.Invoke();
            return 1;
        }
    }
}
