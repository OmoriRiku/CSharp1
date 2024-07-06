//  第三章確認問題

using System;

namespace Ex3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから商品の税抜き金額を入力
            Console.Write("商品の税抜き金額を入力してください：");
            var line = Console.ReadLine();

            //  キーボードから入力した値をint型へ変換する
            var excludingTaxAmount = int.Parse(line);

            //  消費税を求める。
            var consumptionTax = (int)(excludingTaxAmount * 1.1);

            //  結果を出力する
            Console.WriteLine("合計金額：{0}円", consumptionTax);
        }
    }
}
