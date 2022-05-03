﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPractice.Practices;

namespace FirstPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opt;
                do
                {
                    Clear();
                    WriteLine("SELECT A PRACTICE:\n");
                    WriteLine("0) Exit");
                    WriteLine("1) Practice 1");
                    WriteLine("2) Practice 2");
                    WriteLine("3) Practice 3");

                    Write("\n#? ");
                    opt = int.Parse(ReadLine());

                    switch (opt)
                    {
                        case 0: WriteLine("bye."); return;
                        case 1:
                            new Practice1().Start();
                            ReadKey();
                            break;
                        case 2:
                            new Practice2().Start();
                            ReadKey();
                            break;
                        case 3:
                            new Practice3().Start();
                            ReadKey();
                            break;
                        default:
                            WriteLine("Not a valid option");
                            break;

                    }
                } while (opt != 0);

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
