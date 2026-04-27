using Ex_03_11.Modules;

namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        Mouse mouse = new Mouse();
        FlashMemory flashMemory = new FlashMemory();
        Display display = new Display();

        mouse.SendData();
        flashMemory.SendData();
        flashMemory.ReceiveData();
        display.ReceiveData();
    }
}
