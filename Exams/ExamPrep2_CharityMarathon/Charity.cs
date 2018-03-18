namespace ExamPrep2_CharityMarathon
{
    using System;

    public class Charity
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var allRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            long runners = days * trackCapacity > allRunners ? allRunners : days * trackCapacity;
            var totalKms = (runners * averageLaps * lapLength) / 1000;
            Console.WriteLine("Money raised: {0:f2}", (totalKms * moneyPerKm));
        }
    }
}