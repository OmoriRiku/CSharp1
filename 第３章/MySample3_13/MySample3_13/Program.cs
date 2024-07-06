//  +演算子による複数文字列の連結

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = "おはよう。";
            var s2 = "こんにちは。";
            var s3 = "こんばんは。";
            var s4 = "またあした。";
            var str = s1 + s2 + s3 + s4;
            Console.WriteLine(str);
        }
    }
}
