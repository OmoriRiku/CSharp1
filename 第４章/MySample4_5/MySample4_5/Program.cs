//  if分の例(文字列の比較)
using System;

namespace MySample4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください。");
            var lang = Console.ReadLine();
            if (lang == "C#")
            {
                Console.WriteLine("langの値は「C#」です。");
            }
            if (lang != "Java")
            {
                Console.WriteLine("langの値は「Java」ではありません。");
            }
        }
    }
}
