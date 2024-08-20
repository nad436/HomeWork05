using System;
using System.Collections.Generic;

namespace HomeWork05
{
    public static class ExtentionMethod
    {

        public static int Average(List<int> numbers)
        {
            int j = 0;
            int n = 0;
            foreach (int i in numbers)
            {
                j += i;
                n++;
            }
            return j / n;
         
        }
    }
}

