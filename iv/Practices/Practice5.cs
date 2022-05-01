using System;
using static System.Console;
using System.Collections.Generic;

namespace FourthPractice.Practices
{
    // Note: I use a queue just for fun
    internal class Practice5
    {
        public int[,] Array;
        public int Rows;
        public int Cols;

        public void Start()
        {
            try
            {
                bool randomArr;

                Write("Rows: ");
                this.Rows = int.Parse(ReadLine());

                Write("Cols: ");
                this.Cols = int.Parse(ReadLine());

                this.Array = new int[this.Rows, this.Cols];

                Write("Generate random array [Y/n]?: ");
                randomArr = ReadLine().ToLower().Equals("y");

                WriteLine(randomArr ? "Generating random array..." : "Insert values:");

                this.GenerateArray(randomArr);
                this.PrintArray();

                WriteLine("\nReversing array...");
                this.PrintReverseArray();

            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        public void GenerateArray(bool isRandom)
        {
            Random random = new Random();
            for (int r = 0; r < this.Rows; ++r)
                for (int c = 0; c < this.Cols; ++c)
                {
                    if (!isRandom)
                        Write($"M[{r},{c}]: ");
                    this.Array[r, c] = isRandom ? random.Next(0, this.Rows) : int.Parse(ReadLine());
                }
        }

        public void PrintArray()
        {
            for (int r = 0; r < this.Rows; ++r)
            {
                for (int c = 0; c < this.Cols; ++c)
                    Write($" {this.Array[r, c]} ");
                WriteLine("");
            }
        }

        private void PrintReverseArray()
        {
            Queue<int> colsQu;
            Queue<Queue<int>> rowsQu = new Queue<Queue<int>>();
            
            for (int r = 0; r < this.Rows; ++r)
            {
                colsQu = new Queue<int>();
                for (int c = 0; c < this.Cols; ++c)
                    colsQu.Enqueue(this.Array[c, r]);
                rowsQu.Enqueue(colsQu);
            }

            for (int r = 0; r < this.Rows; ++r)
            {
                Queue<int> tmpQu = rowsQu.Dequeue();
                for (int c = 0; c < this.Cols; ++c)
                    Write($" {tmpQu.Dequeue()} ");
                WriteLine("");
            }

        }
    }
}
