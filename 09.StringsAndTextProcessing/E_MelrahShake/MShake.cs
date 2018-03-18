namespace E_MelrahShake
{
    using System;
    using System.Text;

    public class MShake
    {
        public static void Main()
        {
            var inputString = new StringBuilder(Console.ReadLine());
            var pattern = new StringBuilder(Console.ReadLine());

            if (pattern.Length == 0 || inputString.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(inputString.ToString());
                return;
            }

            while (inputString.Length > 0 && pattern.Length > 0)
            {
                var backShake = inputString.ToString().LastIndexOf(pattern.ToString());
                var frontShake = inputString.ToString().IndexOf(pattern.ToString());
                var tempInputString = inputString;
                if (frontShake >= 0 && backShake >= 0)
                {
                    inputString.Remove(backShake, pattern.Length);
                    inputString.Remove(frontShake, pattern.Length);
                    pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    inputString = tempInputString;
                    Console.WriteLine("No shake.");
                    Console.WriteLine(inputString.ToString());
                    return;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(inputString.ToString());
        }
    }
}
