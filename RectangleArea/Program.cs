using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"The area of a rectangle with width {width} and height {height} is: {area}.");
            Console.ReadLine();
		}
    }
}
