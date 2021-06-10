using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 5, 6, 233, 6, 32 };

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            Console.WriteLine("Hello World!");
            
            Console.ReadLine();
        }
    }
}
