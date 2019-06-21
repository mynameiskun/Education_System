using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Range
    {
        int flag = 2;
        int temp = 1;
        int agin = 1;
        public int GetNumber()
        {
            int i = temp + agin;
            agin = temp;
            temp = i;
            flag++;
            if (flag < 20)
            {
                return GetNumber();
            }

            else
            {
                return temp;
            }
        }
    }
}
