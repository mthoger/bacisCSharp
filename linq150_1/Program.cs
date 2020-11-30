using System;
using System.Linq;

namespace linq150_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // opgave 150-1
            //int[] a = { 1, 5, 7, 2, 6, 7, 3, 5, 7, 8, 2, 5, 4, 1 };
            //Console.WriteLine(a.Count());
            //Console.WriteLine(a.Where(i => i == 7).ToList().Count);
            //Console.WriteLine(a.Sum());
            //Console.WriteLine(a.Average());
            //Console.WriteLine(string.Join(' ',a.OrderBy(i => i).ToList()));
            //Console.WriteLine(string.Join(' ', a.Where(i => i > 5).ToList()));
            //Console.WriteLine(string.Join(' ', a.Take(5).ToList()));
            //Console.WriteLine(string.Join(' ', a.Skip(5).Take(5).ToList()));

            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            
            //var res1 = people.OrderBy(i => i.FirstName);
            //foreach (var person in res1)
            //    Console.WriteLine(person.Name);

            var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.FirstName);
            foreach (var person in res2)
                Console.WriteLine(person.Name);

        }
    }
}
