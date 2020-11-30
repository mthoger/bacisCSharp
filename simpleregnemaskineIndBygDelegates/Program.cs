using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_simpel_beregner
{
    class Program
    {

        static void Main(string[] args)
        {
            // Enten
            Func<int, int, int> plus = (a, b) => a + b;
            Func<int, int, int> minus = (a, b) => a - b;
            Func<int, int, int> gange = (a, b) => a * b;
            Func<int, int, int> divider = (a, b) => a / b;


            int res = 0;
            int res1 = Beregner(1, 1, plus);
            Console.WriteLine(res1);

            Console.WriteLine(res);
            int res2 = Beregner(1, 1, minus);
            Console.WriteLine(res2);

            int res3 = Beregner(1, 1,gange);
            Console.WriteLine(res3);

            int res4 = Beregner(1, 1, divider);
            Console.WriteLine(res4);

            var f = FindTilfældigFunktion();
            int res5 = f(5, 5);
            Console.WriteLine(res5);

            var v = FindTilfældigFunktion2(plus,minus,gange,divider);
            res = v(3, 3);
            Console.WriteLine(res);

        }
        public static int Beregner(int a, int b, Func<int,int,int> funktion)
        {
            return funktion(a, b);
        }
        
        public static Func<int,int,int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return (a, b) => a + b;
            if (System.DateTime.Now.Millisecond <= 500)
                return (a, b) => a - b;
            if (System.DateTime.Now.Millisecond <= 750)
                return (a, b) => a * b;

            return (a, b) => a / b;

        }

        public static Func<int, int, int> FindTilfældigFunktion2 (params Func<int, int, int>[] funktioner)
        {
            Console.WriteLine("ny funktion");
            System.Random rnd = new Random();
            int nr = rnd.Next(0, funktioner.Length);
            return funktioner[nr];

        }
    }

}