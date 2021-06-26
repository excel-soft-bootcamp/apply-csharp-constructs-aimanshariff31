using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public abstract class College 
    {
        private string idCard;

        public College(string idCard)
        {
            this.idCard = idCard;
        }
    }

    public class Students
    {
        #region member
        string course;
        public void Choose() { }
        #endregion

        public Students(string course, string idCard) 
        {
            this.course = course;
        }
    }

    public class Teachers
    {
        #region member
        string classRoom;
        public void ManageClassRoom() { }
        public void Train() { }
        #endregion

        public Teachers(string classRoom, string idCard)
        {
            this.classRoom = classRoom;
        }
    }

    public class Staff
    {
        #region member
        string designation;
        public void Plan() { }
        public void Schedule() { }
        public void Organize() { }
        #endregion

        public Staff(string designation, string idCard)
        {
            this.designation = designation;
        }
    }

    public class Guest
    {
        #region members
        string guestSpeakers, alumnus;
        public void Advice() { }
        #endregion

        public Guest(string guestSpeakers, string alumnus, string idCard)
        {
            this.guestSpeakers = guestSpeakers;
            this.alumnus = alumnus;
        }
    }
}