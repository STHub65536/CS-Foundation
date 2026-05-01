using Ex_03_12.Modules;

namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {
        Player player;

        Console.Write("DVDのタイトルを入力してください->");
        player = new DVDPlayer(Console.ReadLine());
        player.UseMachine();

        Console.Write("Blu-rayのタイトルを入力してください->");
        player = new BlurayPlayer(Console.ReadLine());
        player.UseMachine();
    }
}
