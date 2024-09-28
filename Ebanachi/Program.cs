using System;

namespace Ebanachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonachiCalculate(1, 6));
            Console.WriteLine(FibonachiCalculate(2, 8));

            Console.ReadKey();
        }

        private static int FibonachiCalculate(int mode, int value)
        {

            if (mode == 1)
            {
                return CalculateValue(value);
            }

            int index = 2;
            return CalculateSequence(value, index);
        }

        private static int CalculateValue(int n)
        {
            if (n == 0 || n == 1) return n;
            return CalculateValue(n - 1) + CalculateValue(n - 2);
        }

        private static int CalculateSequence(int n, int index)
        {
            if (n == 0 || n == 1) return n;

            if (CalculateValue(index) == n) return index;
            return CalculateSequence(n, ++index);
        }
    }
}
