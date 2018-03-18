namespace ExamPrep4_SweetDessert
{
    using System;

    public class Dessert
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guestsNumber = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPricePerKg = decimal.Parse(Console.ReadLine());

            var dessertSets = Math.Ceiling(guestsNumber / 6);
            var productsPrice = ((2 * bananaPrice) + (4 * eggPrice) + (0.2M * berriesPricePerKg)) * dessertSets;
            if (productsPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {productsPrice:F2}lv.");
            }
            else
            {
                var neededMoney = productsPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
