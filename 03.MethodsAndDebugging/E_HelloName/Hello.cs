namespace E_HelloName
{
    using System;

    public class Hello
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            PrintHello(name);
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!"); ;
        }
    }
}
