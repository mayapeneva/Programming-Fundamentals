namespace Е_CompareCharArrays
{
    using System;
    using System.Linq;

    public class CharArrays
    {
        public static void Main()
        {
            var firstArray = string.Format(Console.ReadLine());
            var secondArray = string.Format(Console.ReadLine());

            var firstCharArray = firstArray.Split(' ').Select(char.Parse).ToArray();
            var secondCharArray = secondArray.Split(' ').Select(char.Parse).ToArray();

            var index = Math.Min(firstCharArray.Length, secondCharArray.Length);
            for (int i = 0; i < index; i++)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    PrintResult(secondCharArray, firstCharArray);
                    break;
                }

                if (firstCharArray[i] < secondCharArray[i])
                {
                    PrintResult(firstCharArray, secondCharArray);
                    break;
                }

                if (firstCharArray.Length > secondCharArray.Length)
                {
                    PrintResult(secondCharArray, firstCharArray);
                    break;
                }

                PrintResult(firstCharArray, secondCharArray);
                break;
            }
        }

        public static void PrintResult(char[] first, char[] second)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
    }
}