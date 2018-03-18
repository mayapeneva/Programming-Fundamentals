namespace Wormhole
{
    using System;
    using System.Linq;

    public class Hole
    {
        public static void Main()
        {
            var wormholes = Console.ReadLine().Split().Select(int.Parse).ToList();

            var counter = 0;
            for (int i = 0; i < wormholes.Count; i++)
            {
                if (wormholes[i] != 0)
                {
                    var index = wormholes[i] - 1;
                    wormholes[i] = 0;
                    i = index;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
