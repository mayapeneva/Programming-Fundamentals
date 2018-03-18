namespace L_BlankReceipt
{
    using System;

    public class BlankReceipt
    {
        public static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine(@"------------------------------
© SoftUni");
        }
    }
}
