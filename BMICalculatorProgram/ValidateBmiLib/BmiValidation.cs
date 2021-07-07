using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateBmiLib
{
    public class BmiValidation
    {
        public void ValidateBmiValue()
        {
            
            double value = CalculateBmiLib.CalculateBmi.bmi;
            
            Display obj = new Display();
            if (value < 18.5)
            { obj.Underweight(); }
            if (value >= 19 & value <= 24)
            { obj.Healthy(); }
            if (value >= 25)
            { obj.Overweight(); }


        }
       
    }
    public class Display
    {
        public void Underweight()
        {
            Console.WriteLine("Underweight");
        }
        public void Healthy()
        {
            Console.WriteLine("Healthy");
        }
        public void Overweight()
        {
            Console.WriteLine("Overweight");
        }
    }
}
