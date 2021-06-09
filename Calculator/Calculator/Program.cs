using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(num1 + num2);



            Console.ReadLine();
        }
    }
}
