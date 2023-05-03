using System;

delegate int IntMod(int x1, int x2, int x3);

class UseStatementLambdas
{
    static void Main()
    {
        IntMod Min = (x1, x2, x3) => {
            int[] b = new int[3];
            b[0] = x1;
            b[1] = x2;
            b[2] = x3;
            Array.Sort(b);
            return b[0];
        };
        IntMod Max = (x1, x2, x3) => {
            int[] b = new int[3];
            b[0] = x1;
            b[1] = x2;
            b[2] = x3;
            Array.Sort(b);
            return b[2];
        };
        IntMod Sum = (x1, x2, x3) => x1 + x2 + x3;
        IntMod Mult = (x1, x2, x3) => x1 * x2 * x3;
        IntMod SrAr = (x1, x2, x3) => (x1 + x2 + x3)/3;
        Console.WriteLine("введите первое число");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите второе число");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите третье число");
        int x3 = Convert.ToInt32(Console.ReadLine());

        IntMod intops = Min;
        Console.WriteLine("минимальное значение:{0}", intops(x1, x2, x3));
        intops = Max;
        Console.WriteLine("максимальное значение:{0}", intops(x1, x2, x3));
        intops = Sum;
        Console.WriteLine("сумма: {0}", intops(x1, x2, x3));
        intops = Mult;
        Console.WriteLine("произведение: {0}", intops(x1, x2, x3));
        intops = SrAr;
        Console.WriteLine("среднее арифметическое: {0}", intops(x1, x2, x3));
    }
}