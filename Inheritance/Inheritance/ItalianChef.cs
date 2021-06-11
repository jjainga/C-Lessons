using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //colon other class (: Chef) this tells C# that the italian cheff is going to inherit everything from the chef class
    //This is the subclass
    class ItalianChef : Chef
    {
        //the override key word over writes the inherited method from the super class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Makes Meatballs");
        }
        public void MakesPizza()
        {
            Console.WriteLine("Makes Pizza");
        }
    }
}
