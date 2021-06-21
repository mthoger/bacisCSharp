using System;

namespace delegates_adv
{
    public delegate void mindelegate1(string t);
    class Program
    {
        static void Main(string[] args)
        {
            mindelegate1 f1 = new mindelegate1(MinSkrivTilConsole);
            f1.Invoke("test");

            mindelegate1 f2 = MinSkrivTilConsole;
            f2("test");
            
            mindelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test###");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
