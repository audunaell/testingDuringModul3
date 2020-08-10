using System;

namespace purePuzzle3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            int c = 12;

            for(int i = 0; i < 8; i++)
            {
                for(int bb = 0; bb < b; bb++)
                {
                    Console.Write(" ");
                }
                for(int ab = 0; ab < a; ab++)
                {
                    Console.Write("#");
                }
                for(int cb = 0; cb < c; cb++)
                {
                    if(c > 1)
                    {
                        Console.Write(" ");
                    }                    
                }
                for (int ab = 0; ab < a; ab++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                if(i < 3)
                {
                    a = a + 1;
                    b = b + 1;
                    c = c - 4;
                } else if(i > 3)
                {
                    a = a - 1;
                    b = b - 1;
                    c = c + 4;
                }
            }
        }
    }
}
