using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileToRead = "file1.txt";

            try
            {
                Console.Write(File.ReadAllText(FileToRead));
                
                Console.WriteLine();
                
                foreach (var Line in File.ReadAllLines(FileToRead))
                {
                    Console.WriteLine(Line);
                }

                Console.WriteLine();

                byte[] ReadingFileByteByByte = File.ReadAllBytes(FileToRead);
                string ConvertingByteToString = Encoding.UTF8.GetString(ReadingFileByteByByte, 0 , ReadingFileByteByByte.Length);
                Console.Write(ConvertingByteToString);

                                
            }
            catch(IOException Ex)
            {
                Console.WriteLine(Ex);
            }
        }
    }
}
