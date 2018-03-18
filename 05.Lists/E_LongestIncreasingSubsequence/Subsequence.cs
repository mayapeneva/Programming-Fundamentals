namespace E_LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Subsequence
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var longestSubsequence = new List<int>();
            for (int i = 0; i < integerList.Count - 3; i++)
            {
                var currentSebsequence = new List<int> { integerList[i] };
                for (int j = 1; j < integerList.Count - 2 && j > i; j++)
                {
                    if (integerList[i] < integerList[j])
                    {
                        currentSebsequence.Add(integerList[j]);
                    }
                    else
                    {
                        j = i;
                    }

                    for (int k = 2; k < integerList.Count - 1 && k > j; k++)
                    {
                        if (integerList[j] < integerList[k])
                        {
                            currentSebsequence.Add(integerList[k]);
                        }
                        else
                        {
                            k = j;
                        }

                        for (int l = 3; l < integerList.Count && l > k; l++)
                        {
                            if (integerList[k] < integerList[l])
                            {
                                currentSebsequence.Add(integerList[l]);
                            }
                        }

                        if (currentSebsequence.Count > longestSubsequence.Count)
                        {
                            longestSubsequence = currentSebsequence;
                        }

                        if (currentSebsequence.Count > 3)
                        {
                            currentSebsequence.RemoveRange(3, currentSebsequence.Count - 3);
                        }
                    }

                    if (currentSebsequence.Count > 2)
                    {
                        currentSebsequence.RemoveRange(2, currentSebsequence.Count - 2);
                    }
                }

                if (currentSebsequence.Count > 1)
                {
                    currentSebsequence.RemoveRange(1, currentSebsequence.Count - 1);
                }
            }

            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}