using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Joshua Jainga";
            char rank = 'S';
            int powerLevel = 9000;
            //float, double, decimal can be used to create a non whole number;
            double money = 50.34; 
            bool isSaiyan = true;
            
            Console.WriteLine(name.IndexOf('h'));
            Console.WriteLine(name.Substring(7, 3));

            Console.ReadLine();
        }
    }
}
