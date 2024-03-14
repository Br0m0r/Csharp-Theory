using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   
    internal interface  IPerson
    {
         string FirstName { get; set; }

         string LastName { get; set; }
         string GetFullName();
         string GetDescription();

       
    }
   
}

    
