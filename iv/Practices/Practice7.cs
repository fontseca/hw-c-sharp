using System;
using static System.Console;
using System.Text.RegularExpressions;
namespace FourthPractice.Practices
{
    internal class Practice7
    {
        public void Start()
        {
            try
            {
                string text;
                
                Write("\nInsert some text: ");
                text = ReadLine();

                WriteLine($"Vowels:\t\t{Regex.Matches(text, @"[aeiou]").Count}");
                WriteLine($"Consonants:\t{Regex.Matches(text, @"[bcdfghjklmnñpqrstvwxyz]").Count}");
                WriteLine($"Digits:\t\t{Regex.Matches(text, @"\d").Count}");

            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
