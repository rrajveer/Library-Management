using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_7
{
    class LibraryMember
    {
       
        public  string Name { get; set; }
        public int Counter { get; set; } = 0;
        public LibraryMember(string name,int counter)
        {
            Name = name;
           Counter= counter;
          
        }

    }
}
