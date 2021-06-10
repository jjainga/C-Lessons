using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Banana";
            string guess = "";

            int guessCount = 0;
            int guessLimit = 3;

            bool outOfGueses = false;

            while (secretWord != guess && !outOfGueses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("See if you can guess my word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    Console.WriteLine("Your guess count is: " + guessCount +" out of " + guessLimit);
                }
                else
                {
                    outOfGueses = true;
                    
                }
            }
            if(outOfGueses)
            {
                Console.WriteLine("You Loose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
            
            Console.ReadLine();
        }
    }
}
