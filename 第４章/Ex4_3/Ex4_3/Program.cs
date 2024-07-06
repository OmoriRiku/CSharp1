using System;

namespace Ex4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var num = int.Parse(line);

            if ((num % 3 == 0) && (num % 5 == 0))
            {
                Console.WriteLine("numは3でも5でも割り切れます。");
            }
        }
    }
}
