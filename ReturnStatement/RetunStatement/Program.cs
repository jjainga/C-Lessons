using System;

namespace RetunStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum, cubedNum;

            Console.Write("What number would you like to cude?");
            userNum = Convert.ToInt32(Console.ReadLine());

            cubedNum = cube(userNum);
            Console.WriteLine(cubedNum);
            Console.ReadLine();
        }

        static int cube(int num) 
        {
            double result = Math.Pow(num, 3);
            return (int)result;
        }
    }
}
