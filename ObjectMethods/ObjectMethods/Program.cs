using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Students student1 = new Students("Joshua", "Economics", 3.8);
            Students student2 = new Students("Blake", "Engineering", 3.3);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.ReadLine();
        }
    }
}
