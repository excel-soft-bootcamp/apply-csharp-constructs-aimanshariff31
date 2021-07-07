using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBmiLib
{
    
        public class ConsoleInput
        {
            public static double weight;
            public static double height, bmi;
            

            public void displayinput()
            {
                Console.WriteLine("BMI Calculator");
                Console.WriteLine("------------------");
                Console.WriteLine("Weight in kg: ");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Height in cm: ");
                height = Convert.ToDouble(Console.ReadLine());

            }


           
           
        }
    
}
