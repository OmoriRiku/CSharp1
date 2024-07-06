//  if分の入れ子のサンプルプログラム
using System;

namespace MySample4_3
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("xの値：");
            var lineX = Console.ReadLine();
            var x = int.Parse(lineX);

            Console.Write("yの値：");
            var lineY = Console.ReadLine();
            var y = int.Parse(lineY);

            if (x == 0)
            {
                Console.WriteLine("xは0です。");
                if (y == 0)
                {
                    Console.WriteLine("yも0です。");
                }
            }
        }
    }
}