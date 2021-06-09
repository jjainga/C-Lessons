using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale;
            bool isTall;

            isMale = true;
            isTall = true;

            // || means Or and && means and, these can help make complex conditions for ifStatements
            
            if(isMale && isTall) 
            {
                Console.WriteLine("You are Male and you are tall");
            } else
            {
                Console.WriteLine("You are not Male or not tall or both");
            }
            
            Console.ReadLine();
        }
    }
}
