using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        Hashtable a = new Hashtable();
        for (int i = 0; i < 10; i++)
        {
            a.Add(Convert.ToString(i), Convert.ToString(i * 3 % 8 + 1));
        }
        ICollection k = a.Keys;

        while (true)
        {
            Console.WriteLine("1.Clear\n" +
                "2.ContainsKey\n" +
                "3.ContainsValue\n" +
                "4.СоруТо\n" +
                "5.GetHashCode\n" +
                "6.Remove\n" +
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Hashtable b = new Hashtable();
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
            else if (s == 2)
            {
                Console.WriteLine("hashtable: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли ключ 3? {a.ContainsKey("3")}") ;
            }
            else if (s == 3)
            {
                Console.WriteLine("hashtable: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли значение 5? {a.ContainsValue("8")}");
            }
        
            else if (s == 4)
            {
                Array c = Array.CreateInstance(typeof(string), a.Count*2);
                Console.WriteLine("hashtable: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                k.CopyTo(c,0);
                Console.Write("array c: ");
                foreach (string i in c)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else if (s == 5)
            {
                Console.WriteLine("hashtable: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine($"хеш-код: {a.GetHashCode()}");

            }
            else if (s == 6)
            {
                Console.WriteLine("hashtable до: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                a.Remove("4");
                Console.WriteLine("после удаления элемента по ключу 4: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

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