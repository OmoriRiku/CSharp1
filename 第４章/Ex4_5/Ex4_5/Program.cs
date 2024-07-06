using System;

namespace Ex4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから入力した値を変数へ代入する。
            Console.Write("0 ~ 100の数値を入力してください：");
            var line = Console.ReadLine();

            //  入力した値をint型へ変換する。
            var num = int.Parse(line);

            if (num < 0 || 100 < num)
            {
                Console.WriteLine("入力した数値に誤りがあります");
                return;
            }
            if (num <= 30)
            {
                Console.WriteLine("不可");
            }
            else if (num <= 60)
            {
                Console.WriteLine("可");
            }
            else if (num <= 80)
            {
                Console.WriteLine("良");
            }
            else if (num <= 100)
            {
                Console.WriteLine("優");
            }
        }
    }
}
