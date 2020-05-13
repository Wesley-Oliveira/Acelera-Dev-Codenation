using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> fib = new List<int>();
            fib.Add(0);
            fib.Add(1);

            for (int i = 2; i <= 13; i++)
                fib.Add(fib[i - 1] + fib[i - 2]);

            return fib;
        }

        public bool IsFibonacci(int numberToTest)
        {
            var fib = Fibonacci();
            return fib.Contains(numberToTest) ? true : false;
        }
    }
}
