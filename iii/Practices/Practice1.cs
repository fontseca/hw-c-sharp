using System;
using static System.Console;
using System.Collections.Generic;

namespace ThirdPractice.Practices
{
    internal class Practice1
    {
        public void Start()
        {
            try
            {
                Write("1) Versión con Array\n");
                Write("2) Versión con List\n");
                Write("#? ");
                switch (int.Parse(ReadLine()))
                {
                    case 1: 
                        ArrayVersion();
                        break;
                    case 2:
                        ListVersion();
                        break;
                    default: throw new Exception("Option is not listed");
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }

        private void ListVersion()
        {
            int gradesNumber;
            List<double> gradesList = new List<double>();
            int passedCounter = 0;

            Write("Cantidad de notas: ");

            gradesNumber = int.Parse(ReadLine());

            for (int i = 0; i < gradesNumber; i++)
            {
                Write($"Nota #{i}: ");
                gradesList.Add(Convert.ToDouble(ReadLine()));
            }

            foreach (var grade in gradesList)
                if (grade >= 60) ++passedCounter;

            WriteLine($"Alumnos aprobados: {passedCounter}");
            WriteLine($"Alumnos reprobados: {gradesNumber - passedCounter}");
        }

        private void ArrayVersion()
        {
            int gradesNumber;
            double[] gradesArr;
            int passedCounter = 0;

            Write("Cantidad de notas: ");

            gradesNumber = int.Parse(ReadLine());
            gradesArr = new double[gradesNumber];

            for (int i = 0; i < gradesNumber; i++)
            {
                Write($"Nota #{i}: ");
                gradesArr[i] = Convert.ToDouble(ReadLine());
            }

            foreach (var grade in gradesArr)
                if (grade >= 60) ++passedCounter;

            WriteLine($"Alumnos aprobados: {passedCounter}");
            WriteLine($"Alumnos reprobados: {gradesNumber - passedCounter}");
        }
    }
}
