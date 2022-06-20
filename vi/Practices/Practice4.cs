using System;
using static System.Console;


namespace SixthPractice.Practices
{
    internal class Practice4
    {
        public void Start()
        {
            double sum = 0;
            double number;
            int upper;

            Write("Number: ");
            number = int.Parse(ReadLine());

            Write("Upper: ");
            upper = int.Parse(ReadLine());

            for (double i = 0; i <= upper; ++i)
                sum += 1 / (number + i);

            Write($"Sum is: {sum}");
        }
    }
}
