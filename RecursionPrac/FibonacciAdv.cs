using System;
using System.Collections.Generic;

namespace RecursionPrac
{
    internal class FibonacciAdv
    {
        private Dictionary<int, long> memo = new Dictionary<int, long>();

        internal long Get(int n)
        {
            Console.WriteLine(n + " ");
            if(n<0) { return 0; }
            if(n==1) { return 1; }

            if(memo.ContainsKey(n)) { return memo[n]; }
            else
            {
                long value = Get(n - 2) + Get(n - 1);
                memo[n] = value;
                return value;
            }
            
        }
    }
}