namespace _2017._02_HornetAssault
{
    using System;
    using System.Linq;

    public class Assault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var BIndex = 0;
            var HIndex = 0;
            while (BIndex < beehives.Length && HIndex < hornets.Length)
            {
                long hornetPower = hornets.Sum();
                if (hornetPower <= beehives[BIndex])
                {
                    hornets[HIndex] = 0;
                    beehives[BIndex] -= (int)hornetPower;
                    HIndex++;
                }
                else
                {
                    beehives[BIndex] = 0;
                }

                BIndex++;
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(h => h != 0)));
            }
        }
    }
}
