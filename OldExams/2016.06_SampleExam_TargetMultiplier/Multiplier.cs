namespace _2016._06_SampleExam_TargetMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Multiplier
    {
        public static void Main()
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new List<List<int>>();
            var rows = rowsAndCols[0];
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToList();
                matrix.Add(line);
            }

            var targetedCell = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var tRow = targetedCell[0];
            var tCol = targetedCell[1];
            var tempNumber = matrix[tRow][tCol] 
                * (matrix[tRow - 1][tCol - 1] + matrix[tRow - 1][tCol] + matrix[tRow - 1][tCol + 1] 
                + matrix[tRow][tCol - 1] + matrix[tRow][tCol + 1] 
                + matrix[tRow + 1][tCol - 1] + matrix[tRow + 1][tCol] + matrix[tRow + 1][tCol + 1]);
            matrix[tRow - 1][tCol - 1] *= matrix[tRow][tCol];
            matrix[tRow - 1][tCol] *= matrix[tRow][tCol];
            matrix[tRow - 1][tCol + 1] *= matrix[tRow][tCol];
            matrix[tRow][tCol - 1] *= matrix[tRow][tCol];
            matrix[tRow][tCol + 1] *= matrix[tRow][tCol];
            matrix[tRow + 1][tCol - 1] *= matrix[tRow][tCol];
            matrix[tRow + 1][tCol] *= matrix[tRow][tCol];
            matrix[tRow + 1][tCol + 1] *= matrix[tRow][tCol];
            matrix[tRow][tCol] = tempNumber;

            for (int j = 0; j < rows; j++)
            {
                Console.WriteLine(string.Join(" ", matrix[j]));
            }
        }
    }
}
