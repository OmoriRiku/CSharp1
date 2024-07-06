//  キーボードから入力した数値が整数、負数、0かを判断し、その結果を表示する

using System;

namespace Ex4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            var line = Console.ReadLine();
            var num = int.Parse(line);

            if (num > 0)
            {
                Console.WriteLine("整数です。");
            }
            else if (num == 0)
            {
                Console.WriteLine("0です。");
            }
            else
            {
                Console.WriteLine("負数です。");
            }
        }
    }
}
