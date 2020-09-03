using System;

namespace BMI_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 1000;
            double weight = 1000;
            double bmi = 1000;
            while(height == 1000 || weight == 1000)
            {
                try
                {
                    Console.WriteLine("Enter height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Now enter weight: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("That's not a number.");
                }
            }
            


            bmi = weight / (height * height);

            Console.WriteLine("BMI = {0:0.0000}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("That is underweight.");
            }else if (bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("That is healthy weight");
            }
            else
            {
                Console.WriteLine("That is overweight");
            }
        }
    }
}
