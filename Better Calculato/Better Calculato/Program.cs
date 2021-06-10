using System;

namespace Better_Calculato
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string op;

            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an Operator: ");
            op = Console.ReadLine();

            Console.Write("Enter a second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Calculate(num1, num2, op);



            Console.ReadLine();
        }

        static double Calculate(double num1, double num2, string op) 
        {
            double result;
            if (op == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result);
                return result;
            }
            else if (op == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result);
                return result;
            }
            else if (op == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);
                return result;
            }
            else if (op =="/")
            {
                result = num1 / num2;
                Console.WriteLine(result);
                return result;
            }
            else
            {
                result = 0;
                Console.WriteLine("Invalid Operator " + op);
                return result;
            }
        }

    }
}
