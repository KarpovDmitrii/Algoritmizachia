using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        Dictionary<string,string> a = new Dictionary<string,string>();
        for (int i = 0; i < 10; i++)
        {
            a.Add(Convert.ToString(i), Convert.ToString(i * 3 % 8 + 1));
        }
        Dictionary<string, string>.KeyCollection k =a.Keys;

        while (true)
        {
            Console.WriteLine("1.Add\n" +
                "2.ContainsKey\n" +
                "3.ContainsValue\n" +
                "4.KeyCollection\n"+
                "5.ValueCollection\n"+
                "6.Remove\n" +
                "7.Clear\n" +
                "0.Завершение программы");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (s == 1)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                a.Add("13", "6");
                Console.WriteLine("итог: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
            }
            else if (s == 2)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли ключ 3? {a.ContainsKey("3")}") ;
            }
            else if (s == 3)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine();
                Console.WriteLine($"есть ли значение 5? {a.ContainsValue("5")}");
            }
        
            else if (s == 4)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);
                }
                Dictionary<string, string>.KeyCollection b =a.Keys;
                Console.WriteLine("коллекция ключей");
                foreach (string i in b)
                {
                    Console.WriteLine(i);
                }
            }
            else if (s == 5)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Dictionary<string, string>.ValueCollection b =a.Values;
                Console.WriteLine("коллекция значений");
                foreach (string i in b)
                {
                    Console.WriteLine(i);
                }
            }
            else if (s == 6)
            {
                Console.WriteLine("Dictionary: ");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
                Console.WriteLine($"удаление по ключу 4: {a.Remove("4")}");
                foreach (string i in k)
                {
                    Console.WriteLine(i + ": " + a[i]);

                }
            }
            else if (s == 7)
            {
                Dictionary<string,string> b = new Dictionary<string,string>();
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