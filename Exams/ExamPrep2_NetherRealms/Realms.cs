namespace ExamPrep2_NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Realms
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, List<decimal>>();
            foreach (var demon in demons)
            {
                if (!result.ContainsKey(demon))
                {
                    result[demon] = new List<decimal>();
                }
                
                var healthRegex = new Regex(@"[^0-9+\-*\/\.]");
                var healthMatches = healthRegex.Matches(demon);
                var health = 0;
                foreach (Match healthMatch in healthMatches)
                {
                    health += (int)char.Parse(healthMatch.Value);
                }

                result[demon].Add(health);

                var damageRegex = new Regex(@"[-|+]?\d+(?:\.\d+)?");
                var damageMatches = damageRegex.Matches(demon);
                var damage = 0m;
                foreach (Match damageMatch in damageMatches)
                {
                    damage += decimal.Parse(damageMatch.Value);
                }

                var multDivErs = demon.Where(c => c == '*' | c == '/').ToArray();
                foreach (var multDivEr in multDivErs)
                {
                    damage = multDivEr == '*' ? damage * 2 : damage / 2;
                }

                result[demon].Add(damage);
            }

            foreach (var demon in result)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:F2} damage");
            }
        }
    }
}
