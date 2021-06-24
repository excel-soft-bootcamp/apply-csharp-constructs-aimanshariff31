using System;

namespace bodymass
{
    class Bmi

    {
        private int kg; //kilogram
        private double m; //meters
        private double bmi; //body mass index 

        public int Weight
        {
            set { this.kg = value; }
            get { return this.kg; }
        }

        public double Height
        {
            set { this.m = value; }
            get { return this.m; }
        }

        public double Bmi_Calc
        {
            set { this.bmi = value; }
            get { return this.bmi; }
        }

    }



    class calculate
    {


        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("-------------------");

            Console.Write("Weight in kg: ");
            int kg;
            kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in cm: ");
            double m;
            m = Convert.ToDouble(Console.ReadLine());

            //calculation of BMI
            double BMI;
            BMI = kg / m * 2;

            if (BMI < 18.5)
            { Console.WriteLine("-> Underweight"); }
            if (BMI >= 19 & BMI <= 24)
            { Console.WriteLine("-> Healthy"); }
            if (BMI >= 25)
            { Console.WriteLine("-> Overweight"); }




        }
    }
}