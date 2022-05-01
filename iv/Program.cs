using System;
using static System.Console;
using FourthPractice.Practices;

namespace FourthPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("0) Exit");
                WriteLine("1) Practice 1");
                WriteLine("2) Practice 2");
                WriteLine("3) Practice 3");
                WriteLine("4) Practice 4");
                WriteLine("5) Practice 5");
                WriteLine("6) Practice 6");

                Write("\n#? ");

                switch (int.Parse(ReadLine()))
                {
                    case 0: WriteLine("bye");  return;
                    case 1:
                        new Practice1().Start();
                        break;
                    case 2:
                        new Practice2().Start();
                        break;
                    case 3:
                        new Practice3().Start();
                        break;
                    case 4:
                        new Practice4().Start();
                        break;
                    case 5:
                        new Practice5().Start();
                        break;
                    case 6:
                        new Practice6().Start();
                        break;
                    default:
                        WriteLine("Not a valid option");
                        break;

                }

            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
