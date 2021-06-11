using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters
{
    class Movie
    {
        //public is open to everyone
        //private is open to only code in this class

        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //Getters and Setters
        //allows access to private from outside the class
        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
