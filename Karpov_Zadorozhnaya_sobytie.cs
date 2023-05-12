using System;

delegate void MyEventHandler(double x, double y);
class MyEvent
{
    public event MyEventHandler SomeEvent;
    public void OnSomeEvent(double x, double y)
    {
        if (SomeEvent != null)
            SomeEvent(x, y);
    }
}

class Program
{
    public static void Add(double x, double y)
    {
        Console.WriteLine($"Сумма: {x + y}");
    }
    public static void Sub(double x, double y)
    {
        Console.WriteLine($"Вычитание: {x - y}");
    }
    public static void Mult(double x, double y)
    {
        Console.WriteLine($"Умножение: {x * y}");
    }
    public static void Div(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("на ноль нельзя делить");
        }
        if (y != 0)
        {
            Console.WriteLine($"Деление: {x / y}");
        }

    }

    static void Main()
    {
        Console.WriteLine("введите х");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите у");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        MyEvent evt = new MyEvent();
        evt.SomeEvent += Add;
        evt.SomeEvent += Sub;
        evt.SomeEvent += Mult;
        evt.SomeEvent += Div;
        evt.OnSomeEvent(x, y);
    }
}