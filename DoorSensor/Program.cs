using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Security _observer_security = new Security();
            DoorSensorHandler _addressOfUpateInfo = new DoorSensorHandler(_observer_security.UpateInfo);

            Sensor _door = new Sensor();

        }
    }
}