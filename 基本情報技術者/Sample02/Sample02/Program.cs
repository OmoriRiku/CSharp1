//  配列の要素の並びを逆順にする。

using System;

namespace Sample02
{
    class Program
    {
        static void Main(String[] args)
        {
            //  int型の配列arrayの初期値を設定
            int[] array = { 1, 2, 3, 4, 5 };


            //  要素の内容を格納する変数。
            //  leftは左からの要素(arrray[0], array[1]...)、rightは右からの要素(arrray[4],array[3]...)。tmpは要素の値を一時的に代入する。
            int left, right, tmp;


            //  配列の要素を表示
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] : " + array[i]);
            }


            //  メッセージを表示
            Console.WriteLine("要素の並びを逆順にする。");


            /*
                配列の要素を逆順にする
             */
            for (left = 0; left < array.Length / 2; left++)
            {
                //  変数rightへ要素の右から値を代入する
                //  array[4], array[3]...
                right = array.Length - left;
                right -= 1;


                //  tmpへarray[right]の要素を一時的に代入する
                //  tmp = array[4], tmp = array[3]...
                tmp = array[right];


                //  array[0]array[1]...の要素をarray[right]へ代入する
                //  iが0の場合の例：array{1, 2, 3, 4, 1}
                array[right] = array[left];


                //  tmpの値をarrayの左の要素へ代入する
                //  iが0の場合の例：array[5, 2, 3, 4, 1]
                array[left] = tmp;
            }


            //  配列の要素を逆順にした結果を表示
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[" + i + "] : " + array[i]);
            }
        }
    }
}