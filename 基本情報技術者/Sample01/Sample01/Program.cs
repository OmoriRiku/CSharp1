/*
    年齢を引数で受け取り、料金を返すfee()メソッドのサンプルプログラム
    0 ～ 3歳は「100」
    3 ～ 9歳は「300」
    9歳以上は 「500」
    を数値型で返す
 */

using System;

namespace Sample01
{
    internal class Program
    {
        static void Main(String[] args)
        {
            //  キーボードから入力した年齢（数値）を変数sAgeに代入
            Console.Write("年齢を入力してください：");
            string sAge = Console.ReadLine();

            //  int型へ変換する
            int age = int.Parse(sAge);

            //  fee()関数を呼び出し、int型のpriceへ代入する
            int price = fee(age);

            //  入力した数値と年齢を画面に表示する。
            string message = string.Format("{0}歳の料金は、{1}円です。", age, price);
            Console.WriteLine(message);
        }

        /*
            年齢を引数で受け取り、料金を返すfee()メソッド
            0 ～ 3歳は「100」
            3 ～ 9歳は「300」
            9歳以上は 「500」
            を数値型で返す
         */
        static int fee(int age)
        {
            //  戻り値用のint型の変数ret
            int ret;

            //  0 ～ 3歳は「100」を代入
            if (age <= 3)
            {
                ret = 100;
            }

            //  3 ～ 9歳は「300」を代入
            else if (age <= 9)
            {
                ret = 300;
            }

            //  9歳以上は500を代入
            else
            {
                ret = 500;
            }

            // 代入された数値を返す
            return ret;
        }
    }
}