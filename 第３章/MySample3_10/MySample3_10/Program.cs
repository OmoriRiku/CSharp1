using System;

namespace MySample3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 100;

            Console.Write("数値を入力してください：");
            var line = Console.ReadLine();

            var count = int.Parse(line);
            var num = total / count;

            Console.WriteLine(num);
        }
    }
}
