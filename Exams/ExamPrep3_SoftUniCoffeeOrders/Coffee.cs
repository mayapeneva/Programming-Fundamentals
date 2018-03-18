namespace ExamPrep3_SoftUniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class Coffee
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var totalPrice = 0m;
            for (int i = 0; i < n; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var price = daysInMonth * capsulesCount * capsulePrice;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}