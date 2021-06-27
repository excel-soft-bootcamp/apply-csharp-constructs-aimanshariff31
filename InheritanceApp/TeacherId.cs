using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp
{
    class TeacherId : IdCardDetails
    {
        private string _Department;
        public class TeacherId(string IdCard, string Name, string CollegeName, string Department):base(IdCard,Name,CollegeName)
        {
        
           this._Department = Department;
        }
    }
}
