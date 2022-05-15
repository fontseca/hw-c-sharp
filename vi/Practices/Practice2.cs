using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthPractice.Practices
{
    internal class Practice2
    {
        public List<Student> StudentsList = new List<Student>();
        public void Start()
        {
            int opt;
            do
            {
                int id;
                double av;
                double max;

                Clear();
                WriteLine("SELECT AN OPTION:\n");
                WriteLine("1) Add students");
                WriteLine("2) Show students");
                WriteLine("3) Show a student's average");
                WriteLine("4) Max. grade");
                WriteLine("0) Exit");

                Write("\n#? ");
                opt = int.Parse(ReadLine());

                switch (opt)
                {
                    case 0: break;
                    case 1:
                        InsertStudents();
                        break;
                    case 2:
                        PrintStudents();
                        ReadKey();
                        break;
                    case 3:
                        Write("Student's ID (?): ");
                        id = int.Parse(ReadLine());

                        av = GetStudentAverage(id);
                        if (Convert.ToBoolean((int) av ^ 0))
                            WriteLine("Averge is: " + Math.Round(av, 2));

                        ReadKey();
                        break;
                    case 4:
                        Write("Student's ID (?): ");
                        id = int.Parse(ReadLine());
                        ShowMaxGrade(id);
                        ReadKey();
                        break;
                    default:
                        WriteLine("Not a valid option");
                        break;

                }
            } while (opt != 0);

        }

        private void InsertStudents()
        {
            int n;

            Write("How may students (?): ");
            n = int.Parse(ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Clear();
                Student st = new Student();
                int grades;

                st.Id = StudentsList.Count + 1;

                WriteLine($"Student #{i}");

                Write("Name: ");
                st.Name = ReadLine();

                Write("How many grades (?): ");
                grades = int.Parse(ReadLine());

                st.Grades = new List<Grade>();

                for (int j = 1; j <= grades; j++)
                {
                    Clear();
                    string tmpGradeName;
                    double tmpGradeValue;

                    WriteLine($"Grade {j}: ");
                    Write("Name: ");
                    tmpGradeName = ReadLine();

                    Write("Value: ");
                    tmpGradeValue = double.Parse(ReadLine());

                    st.Grades.Add(new Grade()
                    {
                        GradeId = j,
                        Name = tmpGradeName,
                        Value = tmpGradeValue

                    });
                }
                StudentsList.Add(st);
            }
        }

        private void PrintStudents()
        {
            foreach (Student st in StudentsList)
            {
                WriteLine($"Id: {st.Id} - Student: {st.Name}");
                st.Grades.ForEach(g => WriteLine("-- Class " + g.Name + " with " + g.Value));
                WriteLine("");
            }
        }

        private double GetStudentAverage(int Id)
        {
            Student st = StudentsList.Find(x => x.Id == Id);
            double sum = 0;

            if (st is null)
            {
                WriteLine("Student not found.");
                return 0;
            }

            WriteLine($"Student {st.Name}");

            st.Grades.ForEach(grade =>
            {
                sum += grade.Value;
            });

            return sum / st.Grades.Count;
        }

        private void ShowMaxGrade(int Id)
        {
            Student st = StudentsList.Find(x => x.Id == Id);

            if (st is null)
            {
                WriteLine("Student not found.");
                return;
            }

            WriteLine($"Student {st.Name}");

            double maxGr = st.Grades.Max(grade => grade.Value);

            WriteLine("Max. Grade: " + maxGr);
        }
    }
}
