using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBmiLib
{
    public class CalculateBmi
    {
       
        double weight1 = CheckBmiLib.ConsoleInput.weight;
        double height1 = CheckBmiLib.ConsoleInput.height;
        public static double bmi;
        public void CalculateBmiValue()
        {
            bmi =weight1 / height1;
            
        }
    }
}
