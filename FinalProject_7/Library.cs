using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
   static class Library
    {
        public static List<Media> media = new List<Media>()
        {
        new Book("Little champ","Book",1,5,4,""),
        new Magazine("Daily News ","Magazine",2,6,5,001,""),
        new Movie("The Hustler  ","Movie",3,3,9,""),
        new Book("The king ","Book",7,9,6,""),
        new Magazine("The Fobes ","Magazine",2,6,5,002,""),
        new Movie("Mad Max  ","Movie",4,2,9,""),
        new Book("Rich Dad ","Book",5,7,8,""),
        new Movie("Toy  Story  ","Movie",4,2,9,""),
        new Movie("Ratatouille  ","Movie",1,9,7,""),
         new Movie("Hashar  ","Movie",1,4,9,""),
          new Book("Treasures","Book",3,5,8,""),

        };

        public static List<LibraryMember> members = new List<LibraryMember>()
        {

            new LibraryMember("Samar",0),
            new LibraryMember("Rajveer",0),
            new LibraryMember("Karan Singh",0),
            new LibraryMember("Keyur",0),
            new LibraryMember("Divneet",0)
        };
       

    }
}
