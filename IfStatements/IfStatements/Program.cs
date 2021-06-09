using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale;
            bool isTall;

            isMale = false;
            isTall = true;

            // || means Or and && means and, these can help make complex conditions for ifStatements
            // ! negation operator

            if (isMale && isTall) {
                Console.WriteLine("You are Male and you are tall");
            } else if (isMale && !isTall)  {
                Console.Write("You are a short male");
            }
            else if (!isMale && isTall) {
                Console.WriteLine("You are not male and you are tall");
            }
            else {
                Console.WriteLine("You are not Male or not tall or both");
            }
            
            Console.ReadLine();
        }
    }
}
