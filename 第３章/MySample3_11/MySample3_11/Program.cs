// +演算子による文字列の連結のサンプル

using System;

namespace MySample3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "渡辺";
            var message = name + "さん、おはようございます。";
            Console.WriteLine(message);
        }
    }
}
