using System;

namespace three_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Duplicate_character obj1 = new Duplicate_character();
            Zero_Exception obj2 = new Zero_Exception();
            Palindrome obj3 = new Palindrome();
            int choose;
            char ch;
            do
            {
                Console.WriteLine("----------------------WELCOME-----------------");


                Console.WriteLine("1.Duplicate Character Remove Program");
                Console.WriteLine("2.Demonstrate DivideByZero Exception Program");
                Console.WriteLine("3.Palindrome Number Program\n\n");
            La:
                Console.WriteLine("Choose any one program");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        obj1.dup();
                        break;
                    case 2:
                        obj2.zero();
                        break;
                    case 3:
                        obj3.pal();
                        break;
                    default:
                        Console.WriteLine("Enter vaild number");
                        goto La;
                        break;
                }
                Console.WriteLine("\n\n\nDo you run again: Y/N");
                ch = Convert.ToChar(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
            

        }
    }
}
