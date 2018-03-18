using System;

namespace E_CenturiesToNanoseconds
{
    public class Program
    {
        private static void Main()
        {
            var centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = Math.Floor(years * 365.2422);

            decimal hours = Math.Floor((decimal)days * 24);
            decimal minutes = Math.Floor(hours * 60);
            decimal seconds = Math.Floor(minutes * 60);

            decimal milliseconds = Math.Floor(seconds * 1000);
            decimal microseconds = Math.Floor(milliseconds * 1000);
            decimal nanoseconds = Math.Floor(microseconds * 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}