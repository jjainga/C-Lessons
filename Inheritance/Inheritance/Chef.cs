using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //This is ther super class
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Makes Salad");
        }
        //virutal is a key word that means it can be overwritten in the subclasses
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Makes BBQ");
        }

    }
}
