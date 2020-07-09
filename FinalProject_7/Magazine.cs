using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
    class Magazine :Book
    {
        int IssueNumber { get; set; }
        public Magazine(string title, string mediaType, int serialNumber, int numberOfLent, int pageCount,int issueNumber,string borrower) : base(title,mediaType,serialNumber,numberOfLent,pageCount, borrower)
        {
            IssueNumber = issueNumber;

        }

    }
}
