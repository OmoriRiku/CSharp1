//  if文の例(キーボードが入力された値が10であればメッセージを表示する。)

using System;

namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから入力した値を変数lineへ代入する。
            Console.Write("数値を入力してください(10)：");
            var line = Console.ReadLine();

            //  入力されたString型の値をint型へ変換する
            var num = int.Parse(line);

            //  10が入力されればメッセージを表示する。
            if (num == 10)
            {
                Console.WriteLine("10と入力されました。");
            }
        }
    }
}
