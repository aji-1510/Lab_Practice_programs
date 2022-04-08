using System;
using System.Collections.Generic;
using System.Text;

namespace generic
{
    public class generic_class<t>
    {
        public void genericMethod( t num)
        {
            Console.Write("\t{0}", num);

        }
    }
}
