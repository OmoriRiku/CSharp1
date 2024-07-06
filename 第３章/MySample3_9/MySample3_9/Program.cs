using System;

namespace MySample3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 998;
            var discount = (int)(total * 0.1);
            var payment = total - discount;

            Console.WriteLine("割引額：{0}円", discount);
            Console.WriteLine("支払額：{0}円", payment);
        }
    }
}
