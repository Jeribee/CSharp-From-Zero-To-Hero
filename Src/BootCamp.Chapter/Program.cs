using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = Console.ForegroundColor;

            Console.WriteLine("Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.");
            
            Console.Write("Name: ");

            string name01 = Console.ReadLine();

            Console.Write("Age: ");
            
            int age01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight (kg): ");

            double weight = double.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");

            double height = double.Parse(Console.ReadLine());

            double meterHeight = height / 100;

            double bmi = weight / (meterHeight * meterHeight);

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("\n" + name01 + " is " + age01 + " years old. Their weight is " + weight + " kg and their height is " + height + " cm. BMI is " + Math.Round(bmi, 2));
            Console.ForegroundColor = color;
        }
    }
}
