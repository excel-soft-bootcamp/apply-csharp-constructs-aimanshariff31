using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp
{
    class StudentId : IdCardDetails
    {
        private string _USN;
        public class StudentId(string IdCard, string Name, string CollegeName, string USN):base(IdCard,Name,CollegeName)
        {
           
            this._USN = USN;  
            
        }
    }
}
