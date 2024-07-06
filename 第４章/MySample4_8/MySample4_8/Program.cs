//  switch分の例

using System;

namespace MySample4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ご希望の時間帯の番号を選択してください。");
            Console.WriteLine(" 1: 10時から12時");
            Console.WriteLine(" 2: 13時から15時");
            Console.WriteLine(" 3: 15時から18時");

            var line = Console.ReadLine();
            var value = int.Parse(line);

            switch (value)
            {
                case 1:
                    Console.WriteLine("10時から12時をご希望ですね。");
                    break;
                case 2:
                    Console.WriteLine("13時から15時をご希望ですね。");
                    break;
                case 3:
                    Console.WriteLine("15じから18時をご希望ですね。");
                    break;
                default:
                    Console.WriteLine("入力した値には誤りがあります。");
                    break;
            }

        }
    }
}
