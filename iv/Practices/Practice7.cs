using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FourthPractice.Practices
{
    internal class Practice7
    {
        public void Start()
        {
            try
            {
                string text;
                var map = new Dictionary<string, int>();

                Write("\nInsert some text: ");
                text = ReadLine();

                MatchCollection vowelMatches = Regex.Matches(text, @"[aeiou]");
                MatchCollection consontantMatches = Regex.Matches(text, @"[bcdfghjklmnñpqrstvwxyz]");
                MatchCollection digitMatches = Regex.Matches(text, @"\d");


                map.Add("Vowels", vowelMatches.Count);
                map.Add("Consontants", consontantMatches.Count);
                map.Add("Digits", digitMatches.Count);
                
                WriteLine($"Vowels:\t\t{map["Vowels"]}");
                WriteLine($"Consonants:\t{map["Consontants"]}");
                WriteLine($"Digits:\t\t{map["Digits"]}");
            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
