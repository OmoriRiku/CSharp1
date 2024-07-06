using System;

namespace MySample2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください。");
            var name = Console.ReadLine();
            Console.WriteLine("{0}さん、こんにちは！", name);
        }
    }
}
