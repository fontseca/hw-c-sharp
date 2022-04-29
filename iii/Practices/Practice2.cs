using System;
using static System.Console;
using System.Collections.Generic;

namespace ThirdPractice.Practices
{
    internal class Practice2
    {
        public void Start()
        {
            try
            {
                int N;
                int[,] matrix;
                Dictionary<string, int> rowSumsMap;
                Dictionary<string, int> columnsSumMap;

                Write("Valor de N: ");
                N = int.Parse(ReadLine());

                if (N > 10)
                {
                    WriteLine("No se recomienda usar valores de N mayores de 10\nCambiando a 10...");
                    N = 10;
                }

                matrix = new int[N, N];

                FillMatrix(matrix, N);
                PrintMatrix(matrix, N);

                WriteLine("\nSUMAS\n-----");

                // Print rows sum
                Write("Filas:\t\t");
                rowSumsMap = AddRows(matrix, N);
                for (int i = 0; i < N; ++i) Write($" ({i}, {rowSumsMap["Row#" + i]}) ");
                WriteLine("");

                // Print columns sum
                Write("Columnas:\t");
                columnsSumMap = AddColumns(matrix, N);
                for (int i = 0; i < N; ++i) Write($" ({i}, {columnsSumMap["Column#" + i]}) ");
                WriteLine("");

                // Print main diagonal
                Write($"Diagonal:\t {AddMainDiagonal(matrix, N)}");
                WriteLine("");

                // Print inverse diagonal
                Write($"Diag. inversa:\t {AddInverseDiagonal(matrix, N)}");
                WriteLine("\n");
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
            }
        }

        private void PrintMatrix(int[,] M, int N)
        {
            WriteLine($"Matriz {N}x{N}");
            WriteLine($"Rango [0, {N}]\n");
            for (int row = 0; row < N; ++row)
            {
                for (int col = 0; col < N; ++col)
                    Write($" {M[row, col]} ");
                WriteLine("");
            }
        }
        private void FillMatrix(int[,] M, int N)
        {
            Random r = new Random();
            for (int row = 0; row < N; ++row)
                for (int col = 0; col < N; ++col)
                    M[row, col] = r.Next(0, N);
        }

        private Dictionary<string, int> AddRows(int[,] M, int N)
        {
            var map = new Dictionary<string, int>();
            int sum;

            for (int row = 0; row < N; ++row)
            {
                sum = 0;
                for (int col = 0; col < N; ++col) sum += M[row, col];
                map.Add("Row#" + row, sum);
            }
            return map;
        }
        private Dictionary<string, int> AddColumns(int[,] M, int N)
        {
            var map = new Dictionary<string, int>();
            int sum;

            for (int col = 0; col< N; ++col)
            {
                sum = 0;
                for (int row = 0; row < N; ++row) sum += M[row, col];
                map.Add("Column#" + col, sum);
            }
            return map;
        }
        private int AddMainDiagonal(int[,] M, int N)
        {
            int sum = 0;
            for (int i = 0; i < N; ++i) sum += M[i, i];
            return sum;
        }
        private int AddInverseDiagonal(int[,] M, int N)
        {
            int sum = 0;
            for (int i = 0; i < N; ++i) sum += M[N - (i + 1), i];
            return sum;
        }
    }
}
