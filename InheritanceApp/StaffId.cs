using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp
{
    class StaffId : IdCardDetails
    {
        private string _Designation;
        public class StaffId(string IdCard, string Name, string CollegeName, string Designation):base(IdCard,Name,CollegeName)
        {
        this._Designation = Designation;
        }
    }
}
