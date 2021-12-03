using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HCI_Term_Project
{
    public class Song
    {


        public string Title { get; set; }
        public string Artist { get; set; }
        public string DateAdded { get; set; }
        public string Time { get; set; }
        

        public Song(string title, string artist, string dateAdded, string time)
        {
            Title = title;
            Artist = artist;
            DateAdded = dateAdded;
            Time = time;
        }
    }
}