using System;
using static System.Console;
using ThirdPractice.Practices;

namespace ThirdPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1) Ejercicio 1");
            WriteLine("2) Ejercicio 2");
            WriteLine("3) Ejercicio 3");
            WriteLine("0) Salir");

            Write("#? ");

            switch (int.Parse(ReadLine()))
            {
                case 0: return;
                case 1:
                    new Practice1().Start();
                    break;
                case 2:
                    new Practice2().Start();
                    break;
                case 3:
                    new Practice3().Start();
                    break;
                default:
                    WriteLine("Opción no es válida");
                    break;

            }
        }
    }
}
