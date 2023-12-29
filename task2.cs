using System;

namespace _27._12._2023_tapşırıq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // klaviaturadan ədəd daxil edirik
            if (n >= 0 && n <= 100)                      // ededin 0 - 100 aralığında olmağını yoxlayır
            {
                if (n > 90 && n <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("A");
                }
                else if (n > 80 && n <= 90)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("B");
                }
                else if (n > 70 && n <= 80)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("C");
                }
                else if (n > 60 && n <= 70)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("D");
                }
                else if (n > 50 && n <= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("E");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("F");
                }
            }
            else
            {
                Console.WriteLine("Zehmet olmazsa, 0 - 100 araliginda eded daxil edin.");
            }
        }
    }
}