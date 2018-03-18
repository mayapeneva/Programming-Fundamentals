namespace Test
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            for (int i = 0; i < rotations; i++)
            {
                var last = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = last;
                for (int k = 0; k < array.Length; k++)
                {
                    sum[k] += array[k];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}