//  switch文による多分岐処理処理のコードにIDEとHTMLを追加

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var term = String.Empty;

            switch (word)
            {
                case "API":
                    term = "Application Programming Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
                case "IDE":
                    term = "Integrated Development Environment";
                    break;
                case "HTML":
                    term = "HyperText Markup Language";
                    break;
            }

            if (term != String.Empty)
            {
                Console.WriteLine("{0}は{1}の略です。", word, term);
            }
        }
    }
}
