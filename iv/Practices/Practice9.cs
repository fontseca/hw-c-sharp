using System;
using static System.Console;
using System.Collections.Generic;

namespace FourthPractice.Practices
{
    internal class Practice9
    {
        public void Start()
        {
            int[] arr;
            var oddStack = new Stack<int>();
            var evenStack = new Stack<int>();
            string N;
            Random r = new Random();

            Write("How many elements? (20) ");
            N = ReadLine();
            arr = new int[N.Equals("") ? 20 : int.Parse(N)];

            // fill array
            for (int i = 0; i < arr.Length; i++) arr[i] = r.Next(1, 99);

            WriteLine("\n\nOriginal array:");
            for (int i = 0; i < arr.Length; i++) Write($" {arr[i]} ");

            for (int i = 0; i < arr.Length; i++)
            if (Convert.ToBoolean(arr[i] & 1))
                oddStack.Push(arr[i]);
            else evenStack.Push(arr[i]);

            // show divided array
            for (int i = 0; i < arr.Length; ++i)
                if (oddStack.Count > 0)
                    arr[i] = oddStack.Pop();
                else if (evenStack.Count > 0) arr[i] = evenStack.Pop();

            // print divided array
            WriteLine("\n\nSplit array:");
            for (int i = 0; i < arr.Length; i++)
                Write($" {arr[i]} ");

        }
    }
}
