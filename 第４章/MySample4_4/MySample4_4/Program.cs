//  if分の例(数値の比較)
using System;

namespace MySample4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            var line = Console.ReadLine();
            var num = int.Parse(line);

            if (num >= 10)
            {
                Console.WriteLine("num >= 10が成り立ちました。");

                String message = "numの値は{0}です。";
                Console.WriteLine(String.Format(message, num));
            }
        }
    }
}
