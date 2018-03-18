namespace _2016._09_Portal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Portal
    {
        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());

            var matrix = new List<List<char>> ();
            var rowIndex = 0;
            var columnIndex = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                var matrixLine = Console.ReadLine().ToList();
                matrix.Add(matrixLine);
                if (matrixLine.Any(s => s == 'S'))
                {
                    rowIndex = i;
                    columnIndex = matrixLine.FindIndex(s => s == 'S');
                }
            }

            var directions = Console.ReadLine();
            for (int j = 0; j < directions.Length; j++)
            {
                var command = directions[j];
                if (command == 'R')
                {
                    columnIndex = columnIndex == matrix[rowIndex].Count - 1 ? 0 : columnIndex + 1;
                }
                else if (command == 'L')
                {
                    columnIndex = columnIndex == 0 ? matrix[rowIndex].Count - 1 : columnIndex - 1;
                }
                else if (command == 'U')
                {
                    rowIndex = rowIndex == 0 ? matrixSize - 1 : rowIndex - 1;
                    while (matrix[rowIndex].Count <= columnIndex)
                    {
                        rowIndex--;
                    }
                }
                else
                {
                    rowIndex = rowIndex == matrixSize - 1 ? 0 : rowIndex + 1;
                    while (matrix[rowIndex].Count <= columnIndex)
                    {
                        rowIndex++;
                    }
                }
            }

            if (matrix[rowIndex][columnIndex] == 'E')
            {
                Console.WriteLine($"Experiment successful. {directions.Length} turns required.");
            }
            else
            {
                Console.WriteLine($"Robot stuck at {rowIndex} {columnIndex}. Experiment failed.");
            }
        }
    }
}
