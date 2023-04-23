using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        SortedList a = new SortedList();
        for (int i = 0; i < 10; i++)
        {
            a.Add(Convert.ToString(i), Convert.ToString(i * 3 % 8 + 1));
        }
        ICollection k = a.Keys;

        while (true)
        {
            Console.WriteLine("1.SetByIndex\n" +
                "2.ContainsKey\n" +
                "3.ContainsValue\n" +
                "4.IndexOfKey\n" +
                "5.IndexOfValue\n" +
                "6.GetByIndex\n" +
                "7.GetValueList\n"+
                "8.Remove\n" +
                "9.Clear\n" +
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                a.SetByIndex(2, "6");
                Console.WriteLine("итог: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
            }
            else if (s == 2)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли ключ 3? {a.ContainsKey("3")}") ;
            }
            else if (s == 3)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли значение 5? {a.ContainsValue("8")}");
            }
        
            else if (s == 4)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"индекс ключа 5: {a.IndexOfKey("5")}");
            }
            else if (s == 5)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine($"индекс значения 7: {a.IndexOfValue("7")}");
            }
            else if (s == 6)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine($"значение по индексу 4: {a.GetByIndex(4)}");
            }
            else if (s == 7)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine("список всех значений");
                foreach (string i in a.GetValueList())
                {
                    Console.WriteLine(i);

                }
            }
            else if (s == 8)
            {
                Console.WriteLine("SortedList: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                a.Remove("2");
                Console.WriteLine("SortedList после удаления значения с ключем 2: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
               
            }
            else if (s == 9)
            {
                SortedList b = new SortedList();
                for (int i = 0; i < 10; i++)
                {
                    b.Add(Convert.ToString(i), Convert.ToString(i * 3 % 8 + 1));
                }
                ICollection kb = b.Keys;
                Console.WriteLine("исходный: ");
                foreach (string i in kb)
                {
                    Console.WriteLine(i + ": " + b[i]);

                }
                Console.WriteLine();
                b.Clear();
                kb = b.Keys;
                Console.WriteLine("итог: ");
                foreach (string i in kb)
                {
                    Console.WriteLine(i + ": " + b[i]);

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
    }
}