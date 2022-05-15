using System;
using static System.Console;
using System.Collections.Generic;

namespace SixthPractice.Practices
{

    class Grade
    {
        public int GradeId;
        public string Name;
        public double Value;
    }

    class Student
    {
        public int Id;
        public string Name;
        public List<Grade> Grades;
    }


    internal class Practice1
    {
        public void Start()
        {
            List<Student> stds = new List<Student>();

            stds.Add(new Student()
            {
                Id = 1,
                Name = "Jeremy Fonseca",
                Grades = new List<Grade>
                {
                    new Grade()
                    {
                        GradeId = 1,
                        Name = "Math",
                        Value = 100
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        Name = "Algorithms",
                        Value = 99
                    }
                }
            });

            stds.Add(new Student()
            {
                Id = 2,
                Name = "Kenneth Lola",
                Grades = new List<Grade>
                {
                    new Grade()
                    {
                        GradeId = 1,
                        Name = "Math",
                        Value = 100
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        Name = "Algorithms",
                        Value = 99
                    }
                }
            });

            stds.Add(new Student()
            {
                Id = 3,
                Name = "Raynner Altamirao",
                Grades = new List<Grade>
                {
                    new Grade()
                    {
                        GradeId = 1,
                        Name = "Math",
                        Value = 100
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        Name = "Algorithms",
                        Value = 100
                    }
                }
            });

            stds.Add(new Student()
            {
                Id = 4,
                Name = "Johan Paiz",
                Grades = new List<Grade>
                {
                    new Grade()
                    {
                        GradeId = 1,
                        Name = "Math",
                        Value = 97
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        Name = "Algorithms",
                        Value = 90
                    }
                }
            });

            stds.Add(new Student()
            {
                Id = 5,
                Name = "Pedro Alfonso",
                Grades = new List<Grade>
                {
                    new Grade()
                    {
                        GradeId = 1,
                        Name = "Math",
                        Value = 100
                    },
                    new Grade()
                    {
                        GradeId = 2,
                        Name = "Algorithms",
                        Value = 70
                    }
                }
            });

            foreach (Student student in stds)
            {
                WriteLine("Student: " + student.Name);
                
                foreach (Grade gr in student.Grades)
                    WriteLine("\t--> " + gr.Name + " with " + gr.Value);
                WriteLine("");
            }

        }
    }
}
