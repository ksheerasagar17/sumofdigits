using System;

namespace sumofdigits
{
    class Program
    {
        public static void Main()
        {
            var from = 1200;
            var to = 1259;
            var increment = 1;
            var sumEquals = 3;
            StartPrinting(from, to, increment, sumEquals);
        }

        static private void StartPrinting(int from, int to, int increment, int sumEquals)
        {
            for (int i = from; i <= to; i = (i + increment))
            {
                var sumOfAlldigits = SumUpAllDigits(i);
                if (sumOfAlldigits == sumEquals)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static private int SumUpAllDigits(int inputNumber)
        {
            var summation = 0;
            while (inputNumber > 0)
            {
                summation += inputNumber % 10;
                inputNumber /= 10;
            }

            if (summation > 9)
            {
                summation = SumUpAllDigits(summation);
            }

            return summation;
        }
    }
}
