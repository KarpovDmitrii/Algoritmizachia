interface IMath
{
    abstract static double Add(double x, double y);

    abstract static double Sub(double x, double y);

    abstract static double Mult(double x, double y);

    abstract static double Div(double x, double y);
    

}
class Program : IMath
{
    public static double Add(double x, double y)
    {
        return x + y;
    }
    public static double Sub(double x, double y)
    {
        return x - y;
    }
    public static double Mult(double x, double y)
    {
        return x * y;
    }
    public static double Div(double x, double y)
    {
        return x / y;
    }

    public delegate double DMath(double x, double y);

    static void Main()
    {
        DMath ad = Add;
        DMath su= Sub;
        DMath Mul = Mult;
        DMath Di = Div;

        Console.WriteLine("введите х");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите у");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        while (true){
            Console.WriteLine("1. x+y \n2. x-y \n3. x*y\n4. x/y\n5.завершение программы");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key == 1)
            {
                Console.WriteLine(ad(x, y));
            }
            if (key == 2)
            {
                Console.WriteLine(su(x, y));
            }
            if (key==3)
            {
                Console.WriteLine(Mul(x, y));

            }
            if (key==4)
            {
                Console.WriteLine(Di(x, y));
            }
            if (key==5)
            {
                return;
            }
            Thread.Sleep(1000);
            Console.WriteLine("Вернуться в меню: Enter");
            ConsoleKeyInfo v = Console.ReadKey(true);
            if (v.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
            Console.Clear();
        }
    }
}