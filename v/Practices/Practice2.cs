using System;
using static System.Console;

namespace FifthPractice.Practices
{
    internal class Practice2
    {
        public void Start()
        {
            bool res;
            double per;
            string response = "Out of level";

            Write("Questions number: ");
            res = int.TryParse(ReadLine(), out int questionsNumber);

            if (!res)
            {
                WriteLine("Invalid input.");
                return;
            }

            Write("Right answers number: ");
            res = int.TryParse(ReadLine(), out int rightAnswers);

            if (!res)
            {
                WriteLine("Invalid input.");
                return;
            }

            if (rightAnswers < 0 || rightAnswers > questionsNumber)
            {
                WriteLine("Invalid input.");
                return;
            }

            per = rightAnswers * 100;
            per /= questionsNumber;
            per = Math.Round(per, 2);

            response =
                per >= 90
                ? "Max level"
                : per >= 75 && per < 90
                ? "Mid-level"
                : per >= 50 && per < 75
                ? "Regular level"
                : response;

            WriteLine("\nPercentage: {0}%", per);
            WriteLine("You level is: " + response);
        }
    }
}
