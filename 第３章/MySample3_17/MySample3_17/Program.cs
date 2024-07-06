//  挿入文字列で文字列を組み立てるサンプルプログラム

using System;

namespace MySample3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = "夏";
            var temperature = 39;
            var str = $"今年の{season}の最高気温は、{temperature}度でした。";
            Console.WriteLine(str);
        }
    }
}
