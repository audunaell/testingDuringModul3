using System;

namespace purePuzzle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            for(int i = 0; i < 8; i++)
            {
                
                for (int d = 0; d < b; d++)
                {
                    Console.Write(" ");
                }
                for (int c = 0; c < a; c++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                
                if(i < 3)
                {
                    a = a + 2;
                    b = b - 1;
                } else if (i > 3)
                {
                    a = a - 2;
                    b = b + 1;
                }
            }
        }
    }
}
