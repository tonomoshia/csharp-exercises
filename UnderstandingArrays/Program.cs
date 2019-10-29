using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //wrong way! (not using arrays)
            //int number1 = 4;
            //int number2 = 8;
            //int number3 = 15;
            //int number4 = 16;
            //int number5 = 23;

            //if (number1 == 16)
            //{

            //}
            //else if (number2 ==16)
            //{

            //}
            //else if (number3 ==16)
            //{

            //}

            //working with an array: creating it and populating it:

            //int[] numbers = new int[5];  //declaring new array 'numbers" and how many elements wil be in it (5).

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            //Console.WriteLine(numbers[1]);  //accessing second element in array
            //Console.WriteLine(numbers.Length); //find out how many items are in the array (we already know because we told it how many we would have)
            //Console.ReadLine();

            // now we will initialize the array and populate it at the same time.
            //compiler will figure out how many items are in the array without us stating it:
            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            //compiler will figure out how many items are in the array without us stating it:
            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David", "Lee" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]); //will print all of the names in the array
            //}
            //Console.ReadLine();

            // easier way:
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //reversing a string by taking a string and converting it to an array of individual characters. 
            //Then we reverse the order of the characters in the array.

            string zig = "You can get what you want out of life " +
                " if you help enough people get what they want.";

            char[] charArray = zig.ToCharArray(); //built in helper method that splits string into characters]
            Array.Reverse(charArray);
            
            foreach (char  zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();


        }
    }
}
