using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceApp
{
    public abstract class IdCardDetails
    {
        private string _idCard;
        private string _Name;
        private string _CollegeName;

        public IdCardDetails(string idCard, string Name, string CollegeName)
        {
            this._idCard = idCard;
            this._Name = Name;
            this._CollegeName = CollegeName;
        }
    }

} 

   

   