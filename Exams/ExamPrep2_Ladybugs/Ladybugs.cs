namespace ExamPrep2_Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = new int[fieldSize];
            for (int i = 0; i < indexes.Count; i++)
            {
                if (indexes[i] < fieldSize && indexes[i] >= 0)
                {
                    result[indexes[i]] = 1; 
                }
            }

            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                var index = long.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);
                if (index < fieldSize && index >= 0 && result[index] == 1)
                {
                    result[index] = 0;
                    var newIndex = direction == "right" ? (index + flyLength) : (index - flyLength);
                    while (newIndex < fieldSize && newIndex >= 0 && result[newIndex] == 1)
                    {
                        newIndex = direction == "right" ? (newIndex + flyLength) : (newIndex - flyLength);
                    }

                    if (newIndex < fieldSize && newIndex >= 0)
                    {
                        result[newIndex] = 1;
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
