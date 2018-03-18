namespace L_PriceChangeAlert2
{

    using System;

    public class PriceAlert
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = FindIfThereIsDifference(previousPrice, currentPrice);
                bool isDifferenceSignificant = FindIfTheDifferenceIsSignificant(difference, treshold);

                string result = FindWhatTheDifferenceIs(currentPrice, previousPrice, difference, isDifferenceSignificant);
                Console.WriteLine(result);

                previousPrice = currentPrice;
            }
        }

        public static string FindWhatTheDifferenceIs(double currentPrice, double previousPrice, double difference, bool isDifferenceSignificant)
        {
            string result = String.Empty;
            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isDifferenceSignificant)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
            }
            else if (isDifferenceSignificant && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
            }
            else if (isDifferenceSignificant && (difference < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
            return result;
        }
        private static bool FindIfTheDifferenceIsSignificant(double difference, double treshold)
        {
            if (Math.Abs(difference) >= treshold*100)
            {
                return true;
            }
            return false;
        }

        private static double FindIfThereIsDifference(double previousPrice, double currentPrice)
        {
            double difference = (currentPrice - previousPrice)*100 / previousPrice;
            return difference;
        }
    }
}