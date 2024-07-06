//  変数が範囲内かを条件OR演算子で判断するif文
using System;

namespace MySample4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 15;
            if (num % 3 == 0 || num % 5 == 0)
            {
                Console.WriteLine("numは3か5で割り切れます。");
            }
        }
    }
}
