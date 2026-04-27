namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] numArr = new int[3];
        for(int i = 0;i < 3; i++)
        {
            Console.Write("数値"+(i+1)+"を入力してください->");
            numArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("入力結果");
        for(int i = 0;i < 3; i++)
        {
            Console.WriteLine("数値"+(i+1)+":"+numArr[i]);
        }
    }
}
