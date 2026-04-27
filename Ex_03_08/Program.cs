using Ex_03_08.Modules;

namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        NetAccount netAccount = new NetAccount();

        Console.Write("口座番号を入力してください->");
        netAccount.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        netAccount.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        netAccount.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        netAccount.Point = int.Parse(Console.ReadLine());

        Console.WriteLine("口座番号："+netAccount.AccountNo+" 口座名義："+netAccount.AccountName+" 残高："+netAccount.Balance+" ポイント："+netAccount.Point);
    }
}
