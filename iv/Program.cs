using System;
using static System.Console;
using FourthPractice.Practices;

namespace FourthPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1) Practice 1");
            WriteLine("2) Practice 2");
            WriteLine("3) Practice 3");
            WriteLine("0) Exit");

            Write("#? ");

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
                    //new Practice3().Start();
                    break;
                default:
                    WriteLine("Not a valid option");
                    break;

            }
        }
    }
}
