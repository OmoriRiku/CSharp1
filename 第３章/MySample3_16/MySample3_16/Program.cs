//  String.Formatで文字列を連結するサンプルプログラム

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample3_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = '夏';
            var temperature = 39;
            var str = String.Format("今年の{0}の最高気温は、{1}度でした。" , season, temperature);
            Console.WriteLine(str);
        }
    }
}
