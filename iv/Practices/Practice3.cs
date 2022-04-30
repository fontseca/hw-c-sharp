using System;
using static System.Console;

namespace FourthPractice.Practices
{
    internal class Practice3
    {
        public void Start()
        {
            try
            {
                double fee;
                int hours;

                Write("Hourly fee ($): ");
                fee = Convert.ToDouble(ReadLine());

                Write("Worked hours per day: ");
                hours = int.Parse(ReadLine());

                WriteLine("Worker's salary per week: ${0}", fee * hours);
            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
