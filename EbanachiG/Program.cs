using System;

namespace EbanachiG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonachi(6));
            Console.ReadKey();
        }

        private static int fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return fibonachi(n - 1) + fibonachi(n - 2);
        }
    }
}
