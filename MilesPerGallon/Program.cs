using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven today?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you used today?");
            double gallons = double.Parse(Console.ReadLine());
            double mpg = miles/gallons;
            Console.WriteLine($"You are getting {mpg} miles per gallon!");
            Console.ReadLine();
        }
    }
}