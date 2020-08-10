using System;

namespace purePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 0;

            for (int i = 0; i < 4; i++)
            {
                for(int d = 0; d < i; d++)
                {
                    Console.Write(" ");
                }

                for(int c = 0; c < a; c++)
                {
                    Console.Write("#");
                }
                a = a - 2;
                Console.WriteLine(" ");
            }            
        }
    }
}
