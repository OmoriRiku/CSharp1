using System;

namespace Ex3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  変数の宣言
            var a = 10;
            var b = 20;
            var x = 30;
            var k = 40;
            var n = 0;

            //  数値の計算
            x /= 2;
            a += b * 2;
            n *= (k + 4);

            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(n);

        }
    }
}
