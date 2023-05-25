using System;

namespace RecursionPrac
{
    internal class Fibonacci
    {
        internal long Get(int n)
        {
            Console.Write(n + " ");
            if(n < 0) { return 0; }
            if(n == 1) { return 1; }
            return Get(n - 2) + Get(n - 1);
        }
    }
}