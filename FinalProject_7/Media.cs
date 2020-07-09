using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
    public abstract class Media
    {
       public string Title { get; set; }
      public  string MediaType { get; set; }
      public  int SerialNumber { get; set; }
        public int NumberOfLent { get; set; }
        public bool Status { get; set; } = true;
      
        public string Borrower { get; set; }
            


        public Media(string title,string mediaType,int serialNumber,int numberOfLot,string borrower)
        {
             Title = title;
            MediaType = mediaType;
            SerialNumber = serialNumber;
            NumberOfLent = numberOfLot;
            Borrower = borrower;

        }

    }
}
