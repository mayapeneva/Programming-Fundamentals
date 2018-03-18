namespace L_GreaterOf2Values
{
    using System;

    internal class GreaterValue
    {
        private static void Main()
        {
            var valueType = Console.ReadLine();
            if (valueType == "int")
            {
                var firstValue = int.Parse(Console.ReadLine());
                var secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(ReturnGreaterValue(firstValue, secondValue));
            }
            else if (valueType == "char")
            {
                var firstValue = char.Parse(Console.ReadLine());
                var secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(ReturnGreaterValue(firstValue, secondValue));
            }
            else
            {
                var firstValue = string.Format(Console.ReadLine());
                var secondValue = string.Format(Console.ReadLine());
                Console.WriteLine(ReturnGreaterValue(firstValue, secondValue));
            }
        }

        public static int ReturnGreaterValue(int v1, int v2)
        {
            return Math.Max(v2, v1);
        }

        public static char ReturnGreaterValue(char v1, char v2)
        {
            return (char)Math.Max(v2, v1);
        }

        public static string ReturnGreaterValue(string v1, string v2)
        {
            if (v1.CompareTo(v2) < 0)
            {
                return v2;
            }
            else
            {
                return v1;
            }
        }
    }
}