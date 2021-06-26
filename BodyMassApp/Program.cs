using System;

namespace BodyMass
{



    class Program
    {


        static void Main(string[] args)
        {
            CheckBmi person = new CheckBmi();
            person.displayinput();
            person.Generate();


        }
    }
}