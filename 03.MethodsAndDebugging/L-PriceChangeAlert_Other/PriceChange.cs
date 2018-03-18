using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double currentPercentige = GetPercentige(lastPrice, currentPrice);
            bool hasDifferences = HasDifference(currentPercentige, threshold);
            string message = GetNotification(currentPrice, lastPrice, currentPercentige, hasDifferences);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    public static string GetNotification(double currentPrice, double lastPrice, double currentPercentige, bool hasDifferences)
    {
        string notification = string.Empty;
        if (currentPercentige == 0)
        {
            notification = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!hasDifferences)
        {
            notification = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currentPercentige);
        }
        else if (hasDifferences && (currentPercentige > 0))
        {
            notification = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currentPercentige);
        }
        else if (hasDifferences && (currentPercentige < 0))
        {
            notification = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currentPercentige);
        }

        return notification;
    }

    public static bool HasDifference(double currentPercentige, double threshold)
    {
        if (Math.Abs(currentPercentige) >= threshold)
        {
            return true;
        }

        return false;
    }

    public static double GetPercentige(double lastPrice, double currentPrice)
    {
        return (currentPrice - lastPrice)*100 / lastPrice;
    }
}
