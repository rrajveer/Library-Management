using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
    class Movie :Media
    {
        int LenthOfMovie { get; set; }
        public Movie(string title, string mediaType, int serialNumber, int numberOfLot, int lengthOfMovie,string borrower) :base(title,mediaType,serialNumber,numberOfLot, borrower)
        {
            LenthOfMovie = lengthOfMovie;
        }


    }
}
