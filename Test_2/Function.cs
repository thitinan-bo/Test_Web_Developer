using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    internal class Function
    {
        public bool IsPrime(int value)
        {
            bool result = false;
            if (value % 2 != 0)
            {
                result = true;
            }
            return result;


        }

    }
}
