﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You cant divide by Zero");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("That isnt a number");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }

            Console.ReadLine();
        }
    }
}
