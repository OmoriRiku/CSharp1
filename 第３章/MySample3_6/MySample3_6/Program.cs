//  複合代入演算子のサンプルプログラム

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 8;

            //  numに2を加える
            num += 2;
            Console.WriteLine(num);

            //  numを4倍する
            num *= 4;
            Console.WriteLine(num);
        }
    }
}
