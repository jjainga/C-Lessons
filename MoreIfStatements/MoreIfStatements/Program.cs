using System;

namespace MoreIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Pick a whole number: ");
            long user = Convert.ToInt64(Console.ReadLine());
            long computer = random.Next();
            long computer2 = random.Next();

            GetMax(user, computer, computer2);


            Console.ReadLine();
        }

        static long GetMax(long num1, long num2, long num3)
        {
            long result;
            if (num1 >= num2 && num1 >= num3) {
                Console.WriteLine("Computer pick: " + num2);
                Console.WriteLine("Computer2 pick: " + num3);
                Console.WriteLine("You win!");
                return result = num1;
            }
            else if (num3 >= num1 && num3 >= num2) {
                Console.WriteLine("Computer pick: " + num2);
                Console.WriteLine("Computer2 pick: " + num3);
                Console.WriteLine("Computer2 wins!");
                return result = num3;

            }
            else {
                Console.WriteLine("Computer pick: " + num2);
                Console.WriteLine("Computer2 pick: " + num3);
                Console.WriteLine("Computer wins!");
                return result = num2;
            }
        }
    }
}
