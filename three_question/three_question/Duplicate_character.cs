using System;
using System.Collections.Generic;
using System.Text;

namespace three_question
{
    class Duplicate_character
    {
        public void dup()
        {
            Console.Write("\nEnter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);
            Console.ReadKey();

        }

    }
}
