namespace L_PrintingTriangle
{
    using System;

    internal class PrintingTriangle
    {
        private static int i;

        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            TrianglePrint(n);
        }

        public static void PrintColumns(int row)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write($"{column} ");
            }
            Console.WriteLine();
        }

        public static void TrianglePrint(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColumns(row);
            }

            for (int row = number - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}