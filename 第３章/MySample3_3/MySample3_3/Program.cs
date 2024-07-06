using System;

namespace MySample3_3
{
    class Program
    {
        static void Main(String[] args)
        {
            //  変数totalはint型
            var total = 998;

            //  変数discountはdouble型
            //  大きいほうの型に合わせる(int型とdouble型)
            var discount = total * 0.1;


            var payment = total - discount;

            Console.WriteLine("割引額：{0}円", discount);
            Console.WriteLine("支払額：{0}円", payment);
        }
    }
}