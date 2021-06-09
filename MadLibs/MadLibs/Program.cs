using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            string planet, adjective, animal;


            Console.Write("Provide a name of a planet: ");
            planet = Console.ReadLine();

            Console.Write("Provide an adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Provide an animal: ");
            animal = Console.ReadLine();

            Console.WriteLine("There was once a small planet called " + planet);
            Console.WriteLine("The air was quite " + adjective + " That it made breathing hard");
            Console.WriteLine("But the " + animal + " loved his home on " + planet + " anyways!");

            Console.ReadLine();
        }
    }
}
