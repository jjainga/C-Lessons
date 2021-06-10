using System;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {
                {1,2,3,4,5 }, //index 0
                {6,7,8,9,10 }, //index 1
                {11,12,13,14,15 } // index 2
            };
            /*
             This is a way to add multiple lines of commments
            */
            Console.WriteLine(numberGrid[2, 3]);
            
            Console.ReadLine();
        }
    }
}
