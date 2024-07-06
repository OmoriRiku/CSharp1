//  入力した値が10かどうかを判定する(if文)

using System;

namespace MySample4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから入力された値を変数へ代入する。
            Console.Write("数値を入力してください。");
            var line = Console.ReadLine();

            //  String型からint型へ変換する。
            var num = int.Parse(line);

            //  入力された数値が10であるか判定する。
            if (num == 10)
            {
                Console.WriteLine("10が入力されました。");
            }
        }
    }
}
