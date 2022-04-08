using System;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            generic_class<int> i = new generic_class<int>();
            generic_class<string> s = new generic_class<string>();
            Console.WriteLine("this is integer value output");
            i.genericMethod(500);
            Console.WriteLine("\nthis is srting value output");
            s.genericMethod("ajith");
            Console.ReadLine();
        }  
    }
}
