namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください->");
        int month = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(month))
        {
            Console.WriteLine(month+"年は閏年です。");
        }
        else
        {
            Console.WriteLine(month+"年は閏年ではありません。");
        }

    }
}
