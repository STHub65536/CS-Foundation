using System.Runtime.CompilerServices;

namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        try
        {
            Console.Write("値1を入力してください->");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("値2を入力してください->");
            int num2 = int.Parse(Console.ReadLine());

            if(calc.Div(num1, num2) != null)
            {
                Console.WriteLine("値1 / 値2 = "+calc.Div(num1, num2));
            }
        }
        catch(InputParameterLessThanZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }

        Console.WriteLine("プログラム正常終了");
    }
}
