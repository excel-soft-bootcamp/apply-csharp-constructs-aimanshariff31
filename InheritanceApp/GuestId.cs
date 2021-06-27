using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp
{
    class GuestId : IdCardDetails
    { 
        private string _VisitingPerson;

        public class GuestId(string IdCard,string Name,string CollegeName,string VisitingPerson):base(IdCard,Name,CollegeName)
        {
            this._VisitingPerson = VisitingPerson;

            
     
         
        }
    }
}
