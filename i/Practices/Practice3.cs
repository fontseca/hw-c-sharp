using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPractice.Practices
{
    internal class Practice3
    {
        public void Start()
        {
            double[] grades = new double[3];
            double av = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Write("Grade #{0}> ", i);
                grades[i] = Convert.ToDouble(ReadLine());
                av += grades[i];
            }

            av /= 3;

            WriteLine($"\nAverage: {av}");
        }
    }
}
