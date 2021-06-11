using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //class is a specification for a new data type
            //used to model complex entities

            //an object is an instance of a class

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book1.title = "Lord of the Rings";
            book1.author = "Tolkein";
            book1.pages = 800;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);


            Console.ReadLine();
        }
    }
}
