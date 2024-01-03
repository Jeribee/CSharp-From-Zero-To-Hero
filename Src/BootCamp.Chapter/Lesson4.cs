using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            PromptString(message: "Name: ", ConsoleColor.Red);
            string name = CheckString();

            PromptString(message: "Age: ", ConsoleColor.Red);
            int age = PromptInt();

            PromptString(message: "Weight (kg): ", ConsoleColor.Red);
            double weight = PromptFloat();

            PromptString(message: "Height (cm): ", ConsoleColor.Red);
            double height = PromptFloat();

            double bmi = CalculateBmi(weight, height);

            PromptString(message: "\n" + name + " is " + age + " years old. Their weight is " + weight + " kg and their height is " + height + " cm. BMI is " + Math.Round(bmi, 2) + "\n", ConsoleColor.DarkGreen);
        }

        public static string CheckString()
        {
            string strInput = Console.ReadLine();
            int result = 0;

            if(int.TryParse(strInput, out result))
            {
                Console.WriteLine("{0} is invalid. Please type a valid response: ", result);
                return CheckString();
            }
            else
            {
                return strInput;
            }
        }
        public static int PromptInt()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= 0 && value <= 120)
            {
                return value;
            }
            else
            {
                Console.WriteLine(input + " is not a valid number.");
                PromptString(message: "Age: ", ConsoleColor.Red);
                return PromptInt();
            }
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
            //double result = double.Parse(Console.ReadLine());
            //return result;
            string input = Console.ReadLine();

            if (double.TryParse(input, out double value) && value >= 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine(input + " is not a valid number. Please input a valid number: ");
                return PromptFloat();
            }
        }
        public static double CalculateBmi(double weight, double height)
        {
            double meterHeight = height / 100;
            double bmi = weight / (meterHeight * meterHeight);
            return bmi;
        }
    }
}
