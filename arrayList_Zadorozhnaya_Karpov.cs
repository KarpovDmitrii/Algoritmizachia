using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        ArrayList a = new ArrayList();
        for (int i = 0; i < 10; i++)
        {
            a.Add(i * 3 % 8 + 1);
        }
        ArrayList b = new ArrayList();
        for (int i = 0; i < 10; i++)
        {
            b.Add(i * 4 % 8 + 2);
        }
        
        while (true)
        {
            Console.WriteLine("1.RemoveRange\n" +
                "2.Reverse\n" +
                "3.Sort\n" +
                "4.AddRange\n" +
                "5.BinarySearch\n" +
                "6.СоруТо\n" +
                "7.IndexOf\n" +
                "8.LastlndexOf\n" +
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.Write("исходный: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.RemoveRange(2, 3);
                Console.Write("итог: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 2)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.Reverse();
                Console.Write("после reverse: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 3)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.Sort();
                Console.Write("после sort: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 4)
            {
                Console.Write("до: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.AddRange(b);
                Console.Write("после AddRange: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 5)
            {
                Console.Write("list: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"какой индекс тройки?(3) {a.BinarySearch(3)} ");
                Console.WriteLine();

            }
            else if (s == 6)
            {
                Array c = Array.CreateInstance(typeof(int), a.Count);
                Console.Write("list a: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                a.CopyTo(c);
                Console.Write("arrey c: ");
                foreach (int i in c)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 7)
            {
                Console.Write("arraylist a: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Console.Write($"index of (3): {a.IndexOf(3)}");
                Console.WriteLine();
            }
            else if (s == 8)
            {
                Console.Write("arraylist a: ");
                foreach (int i in a)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                Console.Write($"Last index of (5): {a.LastIndexOf(5)}");
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
    }
}