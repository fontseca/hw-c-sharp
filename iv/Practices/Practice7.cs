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
                int i;
                var map = new Dictionary<string, int>();

                map.Add("Vowels", 0);
                map.Add("Consontants", 0);
                map.Add("Digits", 0);

                Write("\nInsert some text: ");
                text = ReadLine();

                MatchCollection vowelMatches = Regex.Matches(text, @"[aeiou]");
                MatchCollection consontantMatches = Regex.Matches(text, @"[bcdfghjklmnñpqrstvwxyz]");
                MatchCollection digitMatches = Regex.Matches(text, @"\d");

                for (i = 0; i < vowelMatches.Count; ++i)
                    map["Vowels"]++;

                for (i = 0; i < consontantMatches.Count; ++i)
                    map["Consontants"]++;

                for (i = 0; i < digitMatches.Count; ++i)
                    map["Digits"]++;

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
