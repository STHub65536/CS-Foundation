using Ex_03_09.Modules;

namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("口座番号を入力してください->");
        string accountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        string accountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        int balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        int point = int.Parse(Console.ReadLine());

        NetAccount netAccount = new NetAccount(accountNo, accountName, balance, point);
        netAccount.Print();
        Console.WriteLine(netAccount.ToString());
    }
}
