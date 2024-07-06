using System;

namespace Ex3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("金額を入力してください。");
            var line = Console.ReadLine();

            var amount = int.Parse(line);

            var price = (int)(amount * 0.01) * 5;

            Console.WriteLine($"ポイント5倍：{price}ポイント");
        }
    }
}
