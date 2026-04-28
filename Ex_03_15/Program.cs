namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.Write("値1を入力してください->");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("値2を入力してください->");
        int num2 = int.Parse(Console.ReadLine());

        if(calc.Div(num1, num2) != null)
        {
            Console.WriteLine("値1 / 値2 = "+calc.Div(num1, num2));
        }
        
    }
}
