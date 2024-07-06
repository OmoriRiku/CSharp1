//  decimal型を使用したサンプルコード

using System;

namespace MySample2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var price = 1280m;
            var priceIncludingTax = price * 1.08m;
            Console.WriteLine(priceIncludingTax);
        }
    }
}
