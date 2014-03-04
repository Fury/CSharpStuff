using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les1_3_dll.deel2
{
    public static class Helper
    {
        public static void wissel (ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;

        }
    }
}
