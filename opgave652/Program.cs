using System;

namespace opgave652
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine(SmartToUpper("mikkel"));
                Console.WriteLine(SmartToUpper(""));
                //Console.WriteLine(SmartToUpper(null));
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                
            }
            
        }
        static string SmartToUpper(string tekst)
        {
            if (tekst == null)
            {
                throw new ApplicationException("tekst må ikke være null");
            }

            if (tekst == "")
            {
                throw new ApplicationException("tekst må ikke være tom");
            }
            string firstletter = tekst.Substring(0, 1).ToUpper();
            int strLength = tekst.Length;
            string restOfText = tekst.Substring(1, (strLength-1));
            return firstletter+restOfText;
                    }
    }
}
