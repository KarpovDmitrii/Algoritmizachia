using System;
using System.Collections;
using System.Linq;

public class Program
{
    public static void Main()
    {
        SortedSet<int> a1 = new SortedSet<int>();
        for (int i = 0; i < 5; i++)
        {
            a1.Add(i * 3%8 + 1);
        }
        SortedSet<int> a = new SortedSet<int>();
        for (int i = 0; i < 5; i++)
        {
            a.Add(i * 2 + 1);
        }
        SortedSet<int> b = new SortedSet<int>();
        for (int i = 0; i < 5; i++)
        {
            b.Add(i * 2);
        }
        while (true)
        {
            Console.WriteLine("1.UnionWith\n" +
                "2.IntersectWith\n" +
                "3.GetViewBetween\n" +
                "4.RemoveWhere\n" +
                "5.Reverse\n" +
                "6.IsSubsetOf\n" +
                "7.ExceptWith\n" +
                "8.Contains\n" +
                "9.SymmetricExceptWith\n" +
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
                Print(a1);
                SortedSet<int> ameg = a1.GetViewBetween(2, 5);
                Console.WriteLine($"подмножество, содержащее числа от 2-х до 5-ти: ");
                foreach (int i in ameg)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 4)
            {
                Console.Write("sortedset: ");
                Print(a);
                a.RemoveWhere(s=> s<6);
                Console.Write("после удаления элементов меньше 6-ти: ");
                Print(a);
            }
            else if (s == 5)
            {
                Console.Write("SortedSet: ");
                Print(a);
                IEnumerable<int> c = a.Reverse();
                Console.Write("обратный: ");
                foreach (int i in c)
                {
                    Console.Write($"{i} "); 
                }
                Console.WriteLine();
            }
            else if (s == 6)
            {
                SortedSet<int> c = new SortedSet<int>();
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
                SortedSet<int> c = new SortedSet<int>();
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
                Console.Write("a: ");
                Print(a1);
                Console.Write("b: ");
                Print(b);
                b.SymmetricExceptWith(a1);
                Console.Write("a и b без общих элементов: ");
                Print(b);
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
        void Print(SortedSet<int> collection)
        {
            foreach (int i in collection)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}