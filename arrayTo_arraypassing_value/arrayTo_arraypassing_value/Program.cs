using System;

namespace arrayTo_arraypassing_value
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name1 = new string[] { "AJiht", "sangee", "siva" };
            string[] name2 = new string[3];
            Console.WriteLine("frist array elements ");
            foreach(string nam in name1)
            {
                Console.WriteLine(nam);
            }
            for(int i=0;i<name1.Length;i++)
            {
                name2[i] = name1[i];
            }
            Console.WriteLine("\n\nsecond array elements ");
            foreach(string nam2 in name2)
            {
                Console.WriteLine(nam2);
            }


        }
    }
}
