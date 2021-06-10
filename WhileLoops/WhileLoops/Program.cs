using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("Hello");
            //do while loops check the condition after the first instance is ran 
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
