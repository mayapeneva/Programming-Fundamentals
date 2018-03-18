using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            try
            {
                long n = Convert.ToInt64(number);
                if (n >= -128 && n < 0)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (n >= 0 && n <= 127)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n > 127 && n <= 255)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n >= -32768 && n < -128)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (n > 255 && n <= 32767)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n > 32767 && n <= 65535)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n < -32768 && n >= -2147483648)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
                else if (n > 65535 && n <= 2147483647)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n > 2147483647 && n <= 4294967295)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                else if (n >= -9223372036854775808 && n < -2147483648 && n > 4294967295 && n <= 9223372036854775807)
                {
                    Console.WriteLine($"{n} can fit in:");
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
