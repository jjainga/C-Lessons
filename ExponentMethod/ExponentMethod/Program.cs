using System;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(4, 8));
         
            Console.ReadLine();
        }

        static int GetPow(int num1, int num2)
        {
            int result = 1;
            for (int i = 0; i < num2; i++) {
                result = num1 * result;
            }
            return result;
        }
    }
}
