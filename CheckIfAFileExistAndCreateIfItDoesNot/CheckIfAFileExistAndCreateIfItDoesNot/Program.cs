using System;
using System.IO;

namespace CheckIfAFileExistAndCreateIfItDoesNot
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "file.txt";

            if (File.Exists(FileName))
            {
                Console.WriteLine("Filen " + FileName + " existerer og kan brukes.");
                File.WriteAllText(FileName, "skriver alt dette til filen");
            } else
            {
                File.Create(FileName);               
                Console.WriteLine(FileName + " har blitt laget");                
            }
            
        }
    }
}
