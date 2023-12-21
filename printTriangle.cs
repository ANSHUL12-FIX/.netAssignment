using System;

namespace Star_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patternHeight = 4;
            for(int i = 1; i <= patternHeight; i++)
            {
                for(int j = 1; j <= patternHeight - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
