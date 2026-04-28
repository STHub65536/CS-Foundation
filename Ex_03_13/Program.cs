namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        
        Console.WriteLine("5 * 5 * "+Circle.PI+" = "+Circle.AreaCalculation(5));
        Console.WriteLine("5 * 5 * "+Circle.PI+" = "+circle.AreaCalculation());

        Circle.PI = 3.0;

        Console.WriteLine("5 * 5 * "+Circle.PI+" = "+Circle.AreaCalculation(5));
        Console.WriteLine("5 * 5 * "+Circle.PI+" = "+circle.AreaCalculation());
    }
}
