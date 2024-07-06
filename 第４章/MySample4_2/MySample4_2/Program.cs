//  入力された数値が奇数か偶数かを画面に表示する
using System;

namespace MySample4_2
{
    class Program
    {
        static void Main(String[] args)
        {
            //  キーボードから値を入力する。
            Console.Write("数値を入力してください：");
            var line = Console.ReadLine();

            //  入力された値をint型へ変換する
            var num = int.Parse(line);

            //  奇数か偶数かを画面に表示する
            if (num % 2 == 0)
            {
                Console.WriteLine("偶数です。");
            }
            else
            {
                Console.WriteLine("奇数です。");
            }
        }
    }
}