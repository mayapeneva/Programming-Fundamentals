namespace _2016._06_SampleExam_MatrixOperator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Matrix
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            }

            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "remove":
                        DoRemove(matrix, command);
                        break;

                    case "swap":
                        DoSwap(matrix, command);
                        break;

                    case "insert":
                        DoInsert(matrix, command);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            for (int k = 0; k < matrix.Count; k++)
            {
                if (matrix[k].Count > 0)
                {
                    Console.WriteLine(string.Join(" ", matrix[k]));
                }
            }
        }

        private static void DoInsert(List<List<int>> matrix, string[] command)
        {
            var row = int.Parse(command[1]);
            var element = int.Parse(command[2]);
            matrix[row].Insert(0, element);
        }

        private static void DoSwap(List<List<int>> matrix, string[] command)
        {
            var firstRow = int.Parse(command[1]);
            var secondRow = int.Parse(command[2]);
            var tempRow = matrix[firstRow];
            matrix[firstRow] = matrix[secondRow];
            matrix[secondRow] = tempRow;
        }

        private static void DoRemove(List<List<int>> matrix, string[] command)
        {
            var type = command[1];
            var position = int.Parse(command[3]);
            if (command[2] == "row")
            {
                switch (type)
                {
                    case "even":
                        matrix[position].RemoveAll(n => n % 2 == 0);
                        break;
                    case "odd":
                        matrix[position].RemoveAll(n => n % 2 != 0);
                        break;
                    case "positive":
                        matrix[position].RemoveAll(n => n >= 0);
                        break;
                    case "negative":
                        matrix[position].RemoveAll(n => n < 0);
                        break;
                }
            }
            else
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    if ((matrix[i].Count > position)
                        && ((type == "even" && matrix[i][position] % 2 == 0)
                         || (type == "odd" && matrix[i][position] % 2 != 0)
                         || (type == "positive" && matrix[i][position] >= 0)
                         || (type == "negative" && matrix[i][position] < 0)))
                    {
                        matrix[i].RemoveAt(position);
                    }
                }
            }
        }
    }
}
