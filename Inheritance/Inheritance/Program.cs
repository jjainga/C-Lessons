using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the super class
            Chef Chef = new Chef();
            Chef.MakeChicken();

            //this is the subClass
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakesPizza();
            
            Console.ReadLine();
        }
    }
}
