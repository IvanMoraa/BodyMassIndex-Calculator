using System;

namespace BodyMassIndexCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to BMI Calculator");
                Console.WriteLine("Write your weight");
                    double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write your height in centimeters");
                    double heightInCm = Convert.ToDouble(Console.ReadLine());
                    double heightInMeters = heightInCm / 100.0;
                    double bodyMassIndex = weight / (heightInMeters * heightInMeters);
                Console.WriteLine($"Your BMI is: {bodyMassIndex}");
                    if (bodyMassIndex < 18.5)
                    {
                        System.Console.WriteLine("You have: Underweight");
                    }
                    else if(18.5 <= bodyMassIndex && bodyMassIndex < 24.9)
                    {
                        System.Console.WriteLine("You have: Normal weight");
                    }
                    else if(bodyMassIndex >= 25 && bodyMassIndex < 29.9)
                    {
                        System.Console.WriteLine("You have: Overweight");
                    }
                    else
                    {
                        System.Console.WriteLine("You have: Obesity");
                    }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}, Type: {ex.GetType().Name}");
            }
        }
    }
}
