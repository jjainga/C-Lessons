using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Song cantHoldUs = new Song("Can't Hold Us", "Macklemore", 300);
            Console.WriteLine(Song.songCount);

            Song wontSay = new Song("Won't Say I am In Love", "Meg", 180);
            Console.WriteLine(Song.songCount); 

            Console.ReadLine();
        }
    }
}
