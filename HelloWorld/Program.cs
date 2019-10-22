using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your name: ");
            string myName = Console.ReadLine();
            
            Console.WriteLine("Hello, " + myName + ".");
        }
    }
}
