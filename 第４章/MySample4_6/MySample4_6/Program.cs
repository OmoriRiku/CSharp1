//  変数が範囲内かを条件AND演算子で判断するif文
using System;

namespace MySample4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var month = 6;
            if (1 <= month && month <= 12)
            {
                Console.WriteLine("1以上12以下の数値です。");
            }
        }
    }
}
