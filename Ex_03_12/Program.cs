using Ex_03_12.Modules;

namespace Ex_03_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        Player dvdPlayer = new DVDPlayer(Console.ReadLine());
        dvdPlayer.UseMachine();

        Console.Write("Blu-rayのタイトルを入力してください->");
        Player blurayPlayer = new BlurayPlayer(Console.ReadLine());
        blurayPlayer.UseMachine();
    }
}
