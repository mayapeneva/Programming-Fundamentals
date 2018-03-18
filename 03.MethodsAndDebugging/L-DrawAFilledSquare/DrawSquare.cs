namespace L_DrawAFilledSquare
{
    using System;

    internal class DrawSquare
    {
        private static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            DrawEndLine(number);
            for (int i = 0; i < number - 2; i++)
            {
                DrawMiddleLines(number);
            }
            DrawEndLine(number);
        }

        public static void DrawEndLine(int n)
        {
            string dashes = new string('-', 2 * n);
            Console.WriteLine(dashes);
        }

        public static void DrawMiddleLines(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            string V = new string('\\', n - 1);
            Console.Write('-');
            Console.WriteLine();
        }
    }
}