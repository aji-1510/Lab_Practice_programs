using System;

namespace ArrayAndsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a c# program to input elements in array and search whether an element exists in array or not

            int num1, i, r;
            char ch;
            int[] arr = new int[30];
            Console.WriteLine("Enter the number of elements in the array");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array elements");
            for(i=0;i<num1;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            do
            {
                Console.WriteLine("enter the item to be searched:");
                r = Convert.ToInt32(Console.ReadLine());
                i = 0;
                while ((i < num1) && (r != arr[i]))
                {
                    i++;
                }
                if (i < num1)
                {
                    Console.WriteLine("the element is found in the position {0}", i + 1);
                }
                else
                {
                    Console.WriteLine("element not found");
                }
                Console.WriteLine("Do you want run again: Y/N");
                ch = Convert.ToChar(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
}
