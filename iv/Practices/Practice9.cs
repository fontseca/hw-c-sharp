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
            var oddQueue = new Queue<int>();
            var evenQueue = new Queue<int>();
            string N;
            Random r = new Random();

            Write("How many elements? (20) ");
            N = ReadLine();
            arr = new int[N.Equals("") ? 20 : int.Parse(N)];

            // fill array
            for (int i = 0; i < arr.Length; i++) arr[i] = r.Next(1, 99);

            WriteLine("\n\nOriginal array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Write($" {arr[i]} ");

                if (Convert.ToBoolean(arr[i] & 1))
                    oddQueue.Enqueue(arr[i]);
                else
                    evenQueue.Enqueue(arr[i]);
            }

            // divide array
            for (int i = 0; i < arr.Length; ++i)
                if (oddQueue.Count > 0)
                    arr[i] = oddQueue.Dequeue();
                else if (evenQueue.Count > 0) arr[i] = evenQueue.Dequeue();

            // print divided array
            WriteLine("\n\nDivided array:");
            for (int i = 0; i < arr.Length; i++)
                Write($" {arr[i]} ");

            WriteLine("");
        }
    }
}
