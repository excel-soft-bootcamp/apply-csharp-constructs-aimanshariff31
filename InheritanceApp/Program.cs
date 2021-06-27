using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentId student = new StudentId("2403","Aiman","MIT","4mh17cs400");
            TeacherId teacher = new TeacherId("1100","shariff","MIT","Computer science");
            GuestId guest = new GuestId("1133","shuaib","MIT","Principal");
            StaffId staff = new StaffId("2204","Ahmed","MIT","Lab Technician");
        }
    }
}