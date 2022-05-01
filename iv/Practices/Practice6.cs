using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthPractice.Practices
{
    internal class Practice6 : Practice5
    {
        public new void Start()
        {
            int N;
            bool randomArr;
            Dictionary<string, Dictionary<string, int>> map;

            Write("\nInsert N: ");

            N = int.Parse(ReadLine());
            
            this.Cols = this.Rows = N;
            this.Array = new int[this.Rows, this.Cols];

            Write("Generate random array [Y/n]?: ");
            randomArr = ReadLine().ToLower().Equals("y");

            WriteLine(randomArr ? "Generating random array..." : "Insert values:");
            this.GenerateArray(randomArr);
            this.PrintArray();

            map = this.GetArraysElementsSum();

            WriteLine("\nSummations (ignoring main diagonal):");
            Write("\nRows sums: ");
            for (int i = 0; i < N; i++)
                Write($"(#{i + 1}, {map["Rows"][$"Row#{i}"]}) ");

            Write("\nCols sums: ");
            for (int i = 0; i < N; i++)
                Write($"(#{i + 1}, {map["Cols"][$"Col#{i}"]}) ");

            WriteLine("\n");
        }

        private Dictionary<string, Dictionary<string, int>> GetArraysElementsSum()
        {
            var elementsMap = new Dictionary<string, Dictionary<string, int>>();
            var rowsMap = new Dictionary<string, int>();
            var colsMap = new Dictionary<string, int>();
            int tempSum;

            // get rows sum
            for (int i = 0; i < this.Cols; ++i)
            {
                tempSum = 0;
                for (int j = 0; j < this.Rows; ++j)
                {
                    if (i == j) continue;
                    tempSum += this.Array[i, j];
                }
                rowsMap.Add($"Row#{i}", tempSum);
            }

            // get cols sum
            for (int i = 0; i < this.Cols; ++i)
            {
                tempSum = 0;
                for (int j = 0; j < this.Rows; ++j)
                {
                    if (i == j) continue;
                    tempSum += this.Array[j, i];
                }
                colsMap.Add($"Col#{i}", tempSum);
            }

            elementsMap.Add("Rows", rowsMap);
            elementsMap.Add("Cols", colsMap);
            return elementsMap;
        }
    }
}
