//  入力した文字列が空文字かどうかを判断する

using System;

namespace Ex4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            if (line == String.Empty)
            {
                Console.WriteLine("空文字列です。");
            }
            else
            {
                var message = String.Format("{0}が入力されました。", line);
                Console.WriteLine(message);
            }
        }
    }
}
