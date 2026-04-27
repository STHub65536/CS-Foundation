using Ex_03_10.Modules;

namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        DVDPlayer dvdPlayer = new DVDPlayer(Console.ReadLine());
        dvdPlayer.Play();
        dvdPlayer.Stop();

        Console.Write("Blu-rayのタイトルを入力してください->");
        BlurayPlayer blurayPlayer = new BlurayPlayer(Console.ReadLine());
        blurayPlayer.Play();
        blurayPlayer.Stop();
    }
}
