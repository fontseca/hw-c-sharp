using System;
using static System.Console;

namespace FifthPractice.Practices
{
    internal class Practice1
    {
        public void Start()
        {
            bool res;

            Write("Insert a whole number: ");
            res = int.TryParse(ReadLine(), out int number);

            if (!res)
            {
                WriteLine("Input must be a whole number.");
                return;
            }

            WriteLine("Digits amount: {0}", GetDigitsAmount(number));

            int sum = GetDigitsSum(number);

            WriteLine("Digits sum: {0}", sum);
            WriteLine("Sum is {0}", Convert.ToBoolean((int) sum & 1) ? "odd" : "even");

        }

        private int GetDigitsAmount(int n) => n.ToString().Length;

        private int GetDigitsSum(int x)
        {
            double y = ((double) x) / 10;
            int z = (int) (y - (y % 1));
            return z == 0 ? x : (int) (Math.Round(y % 1, 1) * 10) + GetDigitsSum(z);
        }
    }
}
