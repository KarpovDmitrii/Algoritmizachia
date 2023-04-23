using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        HashSet<int> a1 = new HashSet<int>();
        for (int i = 0; i < 5; i++)
        {
            a1.Add(i * 2 + 1);
        }
        HashSet<int> a = new HashSet<int>();
        for (int i = 0; i < 5; i++)
        {
            a.Add(i * 3%8+1);
        }
        HashSet<int> b = new HashSet<int>();
        for (int i = 0; i < 5; i++)
        {
            b.Add(i * 2);
        }
        while (true)
        {
            Console.WriteLine("1.UnionWith\n" +
                "2.IntersectWith\n" +
                "3.SetEquals\n" +
                "4.Remove\n" +
                "5.Clear\n" +
                "6.IsSubsetOf\n" +
                "7.ExceptWith\n" +
                "8.Contains\n" +
                "9.CopyTo\n" +
                "0.Завершение программы\n");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.Write("a: ");
                Print(a);
                Console.Write("b: ");
                Print(b);
                b.UnionWith(a);
                Console.Write("объединение a и b: ");
                Print(b);
            }
            else if (s == 2)
            {
                Console.Write("a: ");
                Print(a1);
                Console.Write("b: ");
                Print(b);
                a1.IntersectWith(b);
                Console.WriteLine($"пересечение a и b: ");
                Print(a1);
            }
            else if (s == 3)
            {
                Console.Write("a: ");
                Print(a);
                Console.Write("b: ");
                Print(b);
                Console.WriteLine($"содержат ли a и b одни и те же элементы: {a.SetEquals(b)}");
            }
            else if (s == 4)
            {
                Console.Write("hashset: ");
                Print(a);
                a.Remove(7);
                Console.Write("удаляем элемент 7: ");
                Print(a);
            }
            else if (s == 5)
            {
                HashSet<int> c = new HashSet<int>();
                for (int i = 0; i < 5; i++)
                {
                    c.Add(i);
                }
                Console.Write("исходный: ");
                Print(c);
                c.Clear();
                Console.Write("итог: ");
                Print(c);
            }
            else if (s == 6)
            {
                HashSet<int> c = new HashSet<int>();
                for (int i = 0; i < 10; i++)
                {
                    c.Add(i);
                }
                Console.Write("a: ");
                Print(a);
                Console.Write("c: ");
                Print(c);
                Console.WriteLine($"является ли a подмножеством c: {a.IsSubsetOf(c)}");
            }
            else if (s == 7)
            {
                HashSet<int> c = new HashSet<int>();
                for (int i = 0; i < 10; i++)
                {
                    c.Add(i);
                }
                Console.Write("a: ");
                Print(a);
                Console.Write("c: ");
                Print(c);
                c.ExceptWith(a);
                Console.Write("удаляем элементы a из c. c: ");
                Print(c);
            }
            else if (s == 8)
            {
                Console.Write("a: ");
                Print(a);
                Console.WriteLine($"содержит ли a элемент 3: {a.Contains(3)}");
            }
            else if (s == 9)
            {
                int[] mas = new int[a.Count()];
                Console.Write("a: ");
                Print(a);
                a.CopyTo(mas);
                Console.Write("массив-копия: ");
                for (int j = 0; j < a.Count(); j++)
                {
                    Console.Write($"{mas[j]} ");
                }
                Console.WriteLine();
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
        void Print(HashSet<int> collection)
        {
            foreach (int i in collection)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}