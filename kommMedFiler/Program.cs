using System;

namespace kommMedFiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.IO.Directory.Exists(@"c:\temp"));
            
            var files = System.IO.Directory.GetFiles(@"c:\temp");
            foreach (var item in files)
            {
                System.IO.FileInfo f = new System.IO.FileInfo(item);
                Console.WriteLine(f.Name);
            }

            Console.WriteLine(System.IO.File.Exists(@"C:\temp\michael.txt"));
           try {
                   System.IO.File.WriteAllText(@"c:\temp\michael.txt", "xxx");
                    System.IO.File.AppendAllText(@"c:\temp\michael.txt", "yyy");
                }
                catch (System.IO.IOException e) {
                    Console.WriteLine(e);
                }
           


        }
    }
}
