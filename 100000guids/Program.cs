﻿using System;
using System.IO;

namespace _100000guids
{
    class Program
    {
        static void Main(string[] args)
        {
            string sti = "c:\\temp\\data.txt";
            GemGuids(sti);
        }
        static void GemGuids(string sti)
        {
            if (System.IO.File.Exists(sti))
                System.IO.File.Delete(sti);
            using System.IO.StreamWriter w = new StreamWriter(System.IO.File.OpenWrite(sti), System.Text.Encoding.UTF8);
            for (int i = 0; i < 100000; i++)
                w.WriteLine(Guid.NewGuid().ToString());
            w.Close();
        }
    }
}
