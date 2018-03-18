namespace ExamPrep4_ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManip
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "exchange": GetExchanged(array, command[1]); break;
                    case "max": GetMaxMin(array, command); break;
                    case "min": GetMaxMin(array, command); break;
                    case "first": GetFirstLast(array, command); break;
                    case "last": GetFirstLast(array, command); break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine('[' + string.Join(", ", array) + ']');
        }

        private static void GetExchanged(List<int> array, string command)
        {
            var index = int.Parse(command);
            if (index >= 0 && index < array.Count)
            {
                var partToExchange = array.Take(index + 1).ToList();
                array.RemoveRange(0, index + 1);
                array.AddRange(partToExchange);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }

        private static void GetMaxMin(List<int> array, string[] command)
        {
            var maxMin = command[0];
            var evenOdd = command[1];

            var tempArray = evenOdd == "even" ? array.FindAll(n => n % 2 == 0) : array.FindAll(n => n % 2 != 0);
            var maxMinElement = 0;
            if (tempArray.Count > 0)
            {
                maxMinElement = maxMin == "max" ? tempArray.Max() : tempArray.Min();

                var result = array.LastIndexOf(maxMinElement);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void GetFirstLast(List<int> array, string[] command)
        {
            var firstLast = command[0];
            var count = int.Parse(command[1]);
            var evenOdd = command[2];

            var tempArray = evenOdd == "even" ? array.FindAll(n => n % 2 == 0) : array.FindAll(n => n % 2 != 0);
            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else if (tempArray.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                if (count > tempArray.Count)
                {
                    count = tempArray.Count;
                }

                var result = new List<int>();
                if (firstLast == "first")
                {
                    result = tempArray.Take(count).ToList();
                }
                else
                {
                    result = tempArray.Skip(tempArray.Count - count).ToList();
                }

                Console.WriteLine('[' + string.Join(", ", result) + ']');
            }
        }
    }
}