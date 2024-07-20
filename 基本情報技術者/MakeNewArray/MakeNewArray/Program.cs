/* 配列arrayの要素を一つずつ足した配列を表示 */

using System;

namespace MakeNewArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  引数用の配列array
            int[] array = { 3, 2, 1, 6, 5, 4 };

            //  MakeNewArrayの呼び出し
            int[] nums = MakeNewArray(array);

            //  結果の表示
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        static int[] MakeNewArray(int[] array)
        {
            //  戻り値用の配列
            int[] nums = {};

            //  ループ制御用
            int i;

            //  nums配列の値を一時的に格納する
            int tail;

            //  引数array配列[0]の値をnumsの末尾に追加する
            Array.Resize(ref nums, nums.Length + 1);
            nums[0] = array[0];


            //  引数の配列の要素を一つずつ足す
            for (i = 1; i < array.Length; i++)
            {
                //  nums配列の末尾の値をtailへ代入
                tail = nums[nums.Length - 1];

                //  tailとarray[i]の値をnumsの末尾に追加
                Array.Resize(ref nums, nums.Length + 1);
                nums[i] = tail + array[i];
            }

            return nums;
        }
    }
}
