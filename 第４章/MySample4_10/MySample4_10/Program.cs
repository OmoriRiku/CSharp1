//  else if構文を使った多分岐処理

using System;

namespace MySample4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temprature = 29.5;

            if (temprature >= 35.0)
            {
                Console.WriteLine("猛暑日です。");
            }
            else if (temprature >= 30.0)
            {
                Console.WriteLine("真夏日です。");
            }
            else if (temprature >= 25.0)
            {
                Console.WriteLine("夏日です。");
            }
            else
            {
                Console.WriteLine("いずれでもありません。");
            }
        }
    }
}
