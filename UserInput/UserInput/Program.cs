﻿using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name please: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age please: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age);


            Console.ReadLine();
        }
    }
}