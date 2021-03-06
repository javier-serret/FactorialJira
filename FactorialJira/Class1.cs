﻿using System;

namespace FactorialJira
{
    public class Class1
    {
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
            int product = n;
            while (n > 1) {
                product *= n - 1;
                n--;
            }
            return product;
        }
    }
}
