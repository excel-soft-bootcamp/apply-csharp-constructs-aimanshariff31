using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorProgram
{
    public class Program
    {   
            static void Main(string[] args)
            {
               CheckBmiLib.ConsoleInput person = new CheckBmiLib.ConsoleInput();
                person.displayinput();
                CalculateBmiLib.CalculateBmi Calculate = new CalculateBmiLib.CalculateBmi();
                Calculate.CalculateBmiValue();
                ValidateBmiLib.BmiValidation Validate = new ValidateBmiLib.BmiValidation();
                Validate.ValidateBmiValue();
                Console.ReadKey();
            }   
    }
}
