

using System;

namespace String_subtring_startindexLength
{
    class Program
    {
        static void Main(string[] args)
        {
            /* C# program to demonstrate the String.Substring Method (int startIndex, int length) */
            string value;
            Console.Write("Enter the value for string : ");
            value = Console.ReadLine();
            Console.WriteLine("\nSub String for {0} is {1}", value, value.Substring(0, 3));

            Console.ReadLine();
        }
    }
}
