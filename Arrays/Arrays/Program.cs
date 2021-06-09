using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 34, 12, 35, 6, 97, 3};
            string[] friends = new string[5];

            luckyNumbers[2] = 9000;

            friends[0] = "Pickachu";
            friends[1] = "Charizard";



            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(friends[0]);
            
            
            Console.ReadLine();
        }
    }
}
