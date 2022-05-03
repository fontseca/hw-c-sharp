using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthPractice.Practices
{
    internal class Practice10
    {
        public void Start()
        {
            string str1, str2;

            WriteLine("\nAre these words anagrams?");
            
            Write("First word: ");
            str1 = ReadLine();

            Write("Second word: ");
            str2 = ReadLine();

            WriteLine("\nThese words are {0}", AreAnagrams(str1, str2) ? "anagrams :)" : "not anagrams :(");
        }

        private bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            char[] tempArr1 = new char[str1.Length];
            char[] tempArr2 = new char[str2.Length];
            int len = tempArr1.Length; // they must have the same length

            for (int i = 0; i < len; i++)
            {
                tempArr1[i] = str1[i];
                tempArr2[i] = str2[i];
            }

            Array.Sort(tempArr1);
            Array.Sort(tempArr2);

            for (int i = 0; i < len; i++)
                if (tempArr1[i] != tempArr2[i])
                    return false;

            return true;
        }
    }
}
