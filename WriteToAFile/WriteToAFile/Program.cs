using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace WriteToAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string File1Name = "file1.txt";
            string TextForFile1 = "Whatever!!!1";

            try
            {
                File.WriteAllText(File1Name, TextForFile1);
            }
            catch(IOException Ex)
            {
                Console.WriteLine(Ex);
            }

            string File2Name = "file2.txt";
            string[] TextForFile2 = {"Linje 1 bare så du vet.", "Her kommer linje 2 hohoho.", "Og så en tredje linje." };

            try
            {                
                File.WriteAllLines(File2Name, TextForFile2);
            }
            catch(IOException KanKallesHvaSomHelst)
            {
                Console.WriteLine(KanKallesHvaSomHelst);
            }

            string File3Name = "file3.txt";
            byte[] TextForFile3 = { 225, 1, 99 };

            try
            {
                File.WriteAllBytes(File3Name, TextForFile3);
            }
            catch(IOException KanVirkeligKallesHvaSomHelst)
            {
                Console.WriteLine(KanVirkeligKallesHvaSomHelst);
            }
        }
    }
}
