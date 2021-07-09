using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSensor
{
    public delegate void DoorSensorHandler(string status);
    public class Sensor
    {
        string DoorSensorstatus = "DoorClosed";
        public event DoorSensorHandler OnDoorSensorStatusChanged;
        public void OpenDoor()
        {
            DoorSensorstatus = "DoorOpened";
            OnDoorSensorStatusChanged.Invoke(this.DoorSensorstatus);
        }
        
    }
}