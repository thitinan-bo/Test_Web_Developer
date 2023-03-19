using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_odd_even
{
    internal class Function
    {

        public bool IsOdd(int value)
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
