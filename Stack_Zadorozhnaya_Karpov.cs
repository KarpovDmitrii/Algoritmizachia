using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        Stack a = new Stack();
        for (int i = 0; i < 10; i++)
        {
            a.Push(i * 3 % 8 + 1);
        }
        while (true)
        {
            Console.WriteLine("1.Pop\n" +
                "2.Peek\n" +
                "3.Contains\n" +
                "4.ToArray\n" +
                "5.Clear\n" +
                "6.Push\n" +
                "7.Clone\n" +
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.WriteLine("исходный: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.Pop();
                Console.WriteLine("итог: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 2)
            {
                Console.WriteLine("stack: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Console.WriteLine($"элемент, находящийся в начале {a.Peek()}") ;
            }
            else if (s == 3)
            {
                Console.WriteLine("stack: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Console.WriteLine($"есть ли элемент 5? {a.Contains(5)}");
            }
            else if (s == 4)
            {

                Array c = Array.CreateInstance(typeof(int), a.Count);
                Console.WriteLine("stack: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                c = a.ToArray();
                Console.WriteLine("массив-копия: ");
                foreach (int i in c)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (s == 5)
            {
                Stack b = new Stack();
                for (int i = 0; i < 10; i++)
                {
                    b.Push(i * 3 % 8 + 1);
                }
                Console.WriteLine("исходный: ");
                foreach (int i in b)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                b.Clear();
                Console.WriteLine("итог: ");
                foreach (int i in b)
                {
                    Console.Write($"{i} ");

                }
            }
            else if (s == 6)
            {
                Console.WriteLine("исходный: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.Push(11);
                Console.WriteLine("с добавлением элемента 11");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (s == 7)
            {
                Console.WriteLine("stack: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Stack m= (Stack) a.Clone();
                Console.WriteLine("копия: ");
                foreach (int i in m)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (s == 0)
            {
                return;
            }
            Console.WriteLine("Вернуться в меню: Enter");
            ConsoleKeyInfo v = Console.ReadKey(true);
            if (v.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
        }
    }
}