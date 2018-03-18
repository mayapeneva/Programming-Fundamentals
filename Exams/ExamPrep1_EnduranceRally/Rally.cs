namespace ExamPrep1_EnduranceRally
{
    using System;
    using System.Linq;

    public class Rally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split();
            var track = Console.ReadLine().Split();
            var checkpoints = Console.ReadLine().Split().Select(int.Parse);

            for (int i = 0; i < drivers.Length; i++)
            {
                var driver = drivers[i];
                var fuel = (double)(driver.ToCharArray()[0]);
                for (int j = 0; j < track.Length; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        fuel += double.Parse(track[j]);
                    }
                    else
                    {
                        fuel -= double.Parse(track[j]);
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {j}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
