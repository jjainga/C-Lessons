using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Book
    {
        //in Solution explorer Name of program > right click > add > new item

        //can create a custom data type
        //give attributes to the class to define it

        //class attributes

        public string title;
        public string author;
        public int pages;

        //this is a contructor, a method within a class that gets called when the object is being created
        //This allows you to create the objects much faster 
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
