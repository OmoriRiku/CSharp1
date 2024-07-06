using System;

namespace MySample3_2
{
    class Program
    {
        static void Main(String[] args)
        {
            //  int型変数
            var price1 = 1000;
            var price2 = 800;
            var price3 = 1250;

            //  算術演算子は型を合わせて計算する
            var total = price1 + price2 + price3;
            Console.WriteLine("合計：{0}円", total);

            var member = 4;
            var perPerson = total / member;
            Console.WriteLine("1人当たり：{0}円", perPerson);

            var remainder = total % member;
            Console.WriteLine("余り：{0}円", remainder);
        }
    }
}