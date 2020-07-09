using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
    class Book :Media
    {
      public int PageCount { get; set; }

        public Book(string title, string mediaType, int serialNumber, int numberOfLent,  int pageCount,string borrower) :base(title, mediaType, serialNumber, numberOfLent, borrower)
        {
            PageCount = pageCount;
        }


    }
}
