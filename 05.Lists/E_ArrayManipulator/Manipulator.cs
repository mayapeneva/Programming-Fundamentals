namespace E_ArrayManipulator
{
    using System;
    using System.Linq;

    public class Manipulator
    {
        public static void Main()
        {
            var numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "print")
            {
                var action = command[0];
                command.RemoveAt(0);
                var elements = command.Select(int.Parse).ToArray();

                if (action == "add")
                {
                    numbersList.Insert(elements[0], elements[1]);
                }
                else if (action == "addMany")
                {
                    var numbersToAdd = new int[elements.Length - 1];
                    for (int i = 1; i < elements.Length; i++)
                    {
                        numbersToAdd[i - 1] = elements[i];
                    }
                    numbersList.InsertRange(elements[0], numbersToAdd);
                }
                else if (action == "contains")
                {
                    var result = numbersList.FindIndex(x => x == elements[0]);
                    if (result >= 0)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (action == "remove")
                {
                    numbersList.RemoveAt(elements[0]);
                }
                else if (action == "shift")
                {
                    for (int i = 0; i < elements[0]; i++)
                    {
                        numbersList.Add(numbersList[i]);
                    }
                    numbersList.RemoveRange(0, elements[0]);
                }
                else if (action == "sumPairs")
                {
                    for (int i = 0; i < numbersList.Count - 1; i++)
                    {
                        numbersList[i] += numbersList[i + 1];
                        numbersList.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine($"[{string.Join(", ", numbersList)}]");
        }
    }
}