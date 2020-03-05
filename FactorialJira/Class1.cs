using System;

namespace FactorialJira
{
    public class Class1
    {
        public static int Factorial(int n)
        {
            if (n == 0) return 0;
            if (n < 0 || n > 11) throw new ArgumentOutOfRangeException();
            int product = n;
            while (n > 1) {
                product *= n - 1;
            }
            return product;
        }
    }
}
