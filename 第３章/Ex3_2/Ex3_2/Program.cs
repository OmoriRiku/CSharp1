//  第三章確認問題
using System;

namespace Ex3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = 100;               //  int型
            Console.WriteLine(n1);      //  100

            var n2 = 13;                //  int型
            Console.WriteLine(n2);      //  13

            var a1 = n1 + n2;           //  int型
            Console.WriteLine(a1);      //  113

            var a2 = -n1 / n2;          //  int型
            Console.WriteLine(a2);      //  -7

            var a3 = (double)n1 / n2;   //  double型
            Console.WriteLine(a3);      //  

            var a4 = a2 - n1;           //  int型
            Console.WriteLine(a4);      //  

            var a5 = a3 * -2;           //  double型
            Console.WriteLine(a5);      //  

            var a6 = a4 * 2.0M;         //  decimal型
            Console.WriteLine(a6);
        }
    }
}
