using System;
using static System.Console;

namespace SixthPractice.Practices
{
    internal class Practice5
    {
        public void Start()
        {
            for (double x = 1; x <= 2.1; x += 0.1)
                WriteLine(f(x) > 0 ? $"{x}\t{Math.Round(f(x), 2)}\tPOSITIVE" : $"{x}\t{Math.Round(f(x), 2)}\tNEGATIVE");
        }

        private double f(double x) => (4 * Math.Pow(x, 2)) - (16 * x) + 15;
    }
}
