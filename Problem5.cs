using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{

    public class Solution
    {
        public double MyPow(double x, int n)
        {
            double prod = 1.0;
            if (x == 1 || n == 0) return 1;
            if (x == -1)
            {
                if (n % 2 == 0)
                    return prod;
                else
                {
                    return -prod;
                }
            }
            if (n <= int.MinValue) return 0;

                      if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    prod *= x;
                }
            }
            else
            {
                for (int i = 0; i < (-n); i++)
                {
                    prod *= x;
                }
                prod = 1 / prod;
            }
            return prod;
        }
    }

}
