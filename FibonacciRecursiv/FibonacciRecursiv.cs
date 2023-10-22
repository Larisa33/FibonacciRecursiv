using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursiv
{
    public static class Fibonacci
    {
        public static void Generate(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursiv(i) + " ");
            }
        }
        public static int FibonacciRecursiv(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return FibonacciRecursiv(n - 1) + FibonacciRecursiv(n - 2);
        }
    }
}
