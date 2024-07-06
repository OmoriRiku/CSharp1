//  switch文の例
using System;

namespace MySample4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下の文字列を入力してください");
            Console.WriteLine("API, RDB, UI");
             
            var word = Console.ReadLine();
            var term = String.Empty;

            switch (word)
            {
                case "API":
                    term = "Application Program Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
            }

            if (term != String.Empty)
            {
                Console.WriteLine("{0}は{1}の略です。", word, term);
            }
        }
    }
}
