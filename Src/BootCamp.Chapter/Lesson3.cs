using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            PromptString(message: "Name: ", ConsoleColor.Red);
            string name = Console.ReadLine();

            PromptString(message: "Age: ", ConsoleColor.Red);
            int age = PromptInt();

            PromptString(message: "Weight (kg): ", ConsoleColor.Red);
            double weight = PromptFloat();

            PromptString(message: "Height (cm): ", ConsoleColor.Red);
            double height = PromptFloat();

            double bmi = CalculateBmi(weight, height);

            PromptString(message: "\n" + name + " is " + age + " years old. Their weight is " + weight + " kg and their height is " + height + " cm. BMI is " + Math.Round(bmi, 2) + "\n", ConsoleColor.DarkGreen);
        }
        public static int PromptInt()
        {
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        public static void PromptString(string message, ConsoleColor newColor)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
            Console.Write(message);
            Console.ForegroundColor = oldColor;
        }
        static double PromptFloat()
        {
            double result = double.Parse(Console.ReadLine());
            return result;
        }
        public static double CalculateBmi(double weight,  double height)
        {
            double meterHeight = height / 100;
            double bmi = weight / (meterHeight * meterHeight);
            return bmi;
        }
    }
}
