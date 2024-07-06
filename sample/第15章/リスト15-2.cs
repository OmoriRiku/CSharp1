// ■リスト15-2：例外をキャッチする
class Program
{
    static void Main()
    {
        try
        {
            var total = 1000;
            var line = Console.ReadLine();
            var count = int.Parse(line);
            var ans = total / count;
            Console.WriteLine(ans);
            Console.WriteLine("正常終了");
        }
        catch
        {
            Console.WriteLine("入力した値が正しくありません");
        }
    }
}
