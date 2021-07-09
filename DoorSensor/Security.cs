using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensor
{
    public class Security
    {
        public void UpateInfo(string status)
        {
            this.SMS();
        }
        public void SMS()
        {
            Console.WriteLine("Door Sensor Status");
        }

    }
}