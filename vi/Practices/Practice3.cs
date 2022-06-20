using System;
using static System.Console;

namespace SixthPractice.Practices
{
    internal class Practice3
    {
        public void Start()
        {
            int number, result, sum = 0, tmp;
            double len;

            Write("Enter a number: ");
            
            number = int.Parse(ReadLine());
            len = number.ToString().Length;
            tmp = number;

            while (number > 0)
            {
                result = number % 10;
                sum += (int) Math.Pow(result, len);
                number /= 10;
            }

            Write(tmp == sum ? "Armstrong Number.": "Not an Armstrong Number");
        }
    }
}
