using System;
using System.Collections.Generic;
using System.Text;

namespace three_question
{
    class Zero_Exception
    {
        public void zero()
        {
            try
            {
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
        }
    }
}
