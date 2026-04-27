namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("5を加算した結果は"+(num+5)+"です");
        Console.WriteLine("5を加算した結果は"+(num-5)+"です");
    }
}
