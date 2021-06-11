using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie starWars = new Movie("Star Wars", "George Lucus", "PG");
            //rating can only be
            //G, PG, PG-13, R, NR

            avengers.Rating = "Cat";
            //Should return NR because of the invalid attribute after being filtered though the setter
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
