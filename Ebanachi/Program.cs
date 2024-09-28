using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ebanachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonachiCalculate(1, 6));
            Console.WriteLine(fibonachiCalculate(2, 8));

            Console.ReadKey();
        }

        private static int fibonachiCalculate(int mode, int value)
        {
            int counter = 2;
            int preValue = secondValueAndSequence;
            int prePreValue = firstValueAndSequence;

            if (value == 0) return firstValueAndSequence;
            else if (value == 1) return secondValueAndSequence;

            if (mode == 1)
            {
                return CalculateValue(value, ref counter, ref preValue, ref prePreValue);
            }

            return CalculateSequence(value, ref counter, ref preValue, ref prePreValue);
        }

        private static int CalculateValue(int sequence, ref int counter, ref int pre, ref int prePre)
        {
            int currentValue = pre + prePre;
            prePre = pre;
            pre = currentValue;
            counter++;

            if (counter <= sequence)
            {
                currentValue = CalculateValue(sequence, ref counter, ref pre, ref prePre);
            }

            return currentValue;
        }

        private static int CalculateSequence(int value, ref int counter, ref int pre, ref int prePre)
        {
            int currentValue = pre + prePre;
            prePre = pre;
            pre = currentValue;

            if (currentValue != value)
            {
                counter++;
                currentValue = CalculateSequence(value, ref counter, ref pre, ref prePre);
            }

            return counter;
        }

        private const int firstValueAndSequence = 0;
        private const int secondValueAndSequence = 1;
    }
}
