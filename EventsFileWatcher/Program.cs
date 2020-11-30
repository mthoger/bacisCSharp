using System;

namespace EventsFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w =  new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
             w.EnableRaisingEvents = true;
            // bind en metode til w.Changed
            w.Changed += W_changed;
            w.Changed += (s, e) => Console.WriteLine("Der er lavet ændringer til filen " + e.Name);
            Console.ReadKey();

        }
        private static void W_changed (object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Der er lavet ændringer til filen " + e.Name);
        }
    }

}
