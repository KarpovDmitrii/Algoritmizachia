using System;
using System.Collections;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> a = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            a.Add(i * 3 % 8 + 1);
        }
        List<int> b = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            b.Add(i * 2);
        }
        while (true)
        {
            Console.WriteLine("1.AddRange\n" +
                "2.BinarySearch\n" +
                "3.GetRange\n" +
                "4.InsertRange\n" +
                "5.Reverse\n" +
                "6.IndexOf\n" +
                "7.LastIndexOf\n" +
                "8.RemoveRange\n" +
                "9.Sort\n" +
                "0.Завершение программы\n");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.Write("list: ");
                Print(a);
                Console.Write("collection: ");
                Print(b);
                a.AddRange(b);
                Console.Write("объединение a и b: ");
                Print(a);
            }
            else if (s == 2)
            {
                Console.Write("list (отсортированный): ");
                b.Sort();
                Print(b);
                int g = b.BinarySearch(4);
                Console.WriteLine($"индекс элемента 4: {g}");
            }
            else if (s == 3)
            {
                Console.Write("list: ");
                Print(a);
                List<int> c = a.GetRange(1, 2);
                Console.WriteLine($"подмножество, с индекса 1, 2 элемента: ");
                foreach (int i in c)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 4)
            {
                Console.Write("list: ");
                Print(a);
                Console.Write("collection: ");
                Print(b);
                a.InsertRange(2, b);
                Console.Write("после вставления коллекции, начиная с элемента с индексом 2: ");
                Print(a);
            }
            else if (s == 5)
            {
                Console.Write("list: ");
                Print(b);
                b.Reverse(0, 3);
                Console.Write("часть коллекции в обратном порядке: ");
                Print(b);
            }
            else if (s == 6)
            {
                Console.Write("list: ");
                Print(a);
                Console.Write($"индекс первой 4-ки: {a.IndexOf(4)}");
                Console.WriteLine();
            }
            else if (s == 7)
            {
                Console.Write("list: ");
                Print(a);
                Console.Write($"индекс последней 4-ки: {a.LastIndexOf(4)}");
                Console.WriteLine();
            }
            else if (s == 8)
            {
                Console.Write("list: ");
                Print(a);
                a.RemoveRange(1, 3);
                Console.Write("после удаления части коллекции: ");
                Print(a);
            }
            else if (s == 9)
            {
                Console.Write("list: ");
                Print(a);
                a.Sort();
                Console.Write("отсортированный: ");
                Print(a);
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
        void Print(List<int> collection)
        {
            foreach (int i in collection)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}