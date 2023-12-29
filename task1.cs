using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //klaviaturadan ədəd daxil edir

            if (n % 2 == 0)
            {
                Console.WriteLine("n ededi cüt ededdir.");
            }
            else if (n == 0)
            {
                Console.WriteLine("n ededi ne tek ededdir, ne de cüt edededir.");
            }
            else
            {
                Console.WriteLine("n ededi tek ededdir.");
            }

        }
    }
}
