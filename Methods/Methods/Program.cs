using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.Write("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            SayHi(name, age);
            
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age + " years old");
        }

    }
}
