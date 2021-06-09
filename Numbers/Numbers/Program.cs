using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;

            double a = 6.25;
            double b = 8.48;


            Console.WriteLine((x + y) * y);
            Console.WriteLine(Math.Abs(-999));
            Console.WriteLine(Math.Pow(4,4));
            Console.WriteLine(Math.Sqrt(144));
            Console.WriteLine(Math.Max(1,99));
            Console.WriteLine(Math.Min(1,99));
            Console.WriteLine(Math.Round(-5.23421));

            Console.ReadLine();
        }
    }
}
