using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        //static attributes are not unique to each object
        //they are the same accross all objects from the same class
        public static int songCount = 0;

        //constructor
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //increments the song Count to the Sone contructor gets called each time a song is created
            songCount++;

        }
        //could create a getter method to call from each object 
        public int getSoungCount()
        {
            return songCount;
        }
    }
}
