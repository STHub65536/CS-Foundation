namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力して下さい->");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Mul3(n));
    }

    private static int Mul3(int num)
    {
        return num * 3;
    }
}
