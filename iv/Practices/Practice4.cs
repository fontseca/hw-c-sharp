using System;
using static System.Console;
using System.Collections.Generic;

namespace FourthPractice.Practices
{
    internal class Practice4
    {
        public void Start()
        {
            try
            {
                string sentence;
                var map = new Dictionary<char, int>();

                Write("Insert a sentence: ");
                sentence = ReadLine();
                sentence = sentence.Replace(" ", "");
                sentence = sentence.ToLower();

                foreach (char l in sentence)
                    if (!map.ContainsKey(l))
                        map.Add(l, 1);
                    else map[l]++;

                foreach (char l in map.Keys)
                    WriteLine("'{0}' occurs {1}", l, map[l] == 1 ? "once" : map[l] == 2 ? "twice" : $"{map[l]} times");

            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
