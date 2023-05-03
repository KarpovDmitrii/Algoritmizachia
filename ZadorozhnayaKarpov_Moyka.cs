class Avtomobile
{
    public string marka;
    public int nomer;
    public Avtomobile(string marka, int nomer)
    {
        this.marka = marka;
        this.nomer = nomer;
    }
    public void Deconstruct(out string avtomarka, out int avtonomer)
    {
        avtomarka = marka;
        avtonomer = nomer;
    }
}
class Garag
{
    public static List<Avtomobile> garag = new List<Avtomobile>() ;
    public static void Add(Avtomobile a)
    {
        (string marka, int nomer) = a;
        garag.Add(a);
        Console.WriteLine($"Автомобиль {marka} {nomer} добавлен");
    }
    public static List<Avtomobile> Vernut()
    {
        return garag;
    }
}
class Moika
{
    public static void Pomit(Avtomobile a)
    {
        (string marka, int nomer) = a;
        Console.WriteLine($"автомобиль {marka} {nomer} помыт");
    }
}
delegate void Zabota(Avtomobile a);

class Programm
{
    static void Main()
    {
        while (true)
        {
            Zabota pomit = Moika.Pomit;
            Console.WriteLine("1. Добавить автомобиль\n2. Помыть машины\n3. Завершение программы");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (p == 1)
            {
                Console.Write("марка: ");
                string marka = Console.ReadLine();
                Console.Write("номер: ");
                int nomer = Convert.ToInt32(Console.ReadLine());
                Avtomobile a = new Avtomobile(marka, nomer);
                Garag.Add(a);
            }
            if (p == 2)
            {
                List<Avtomobile>  a = Garag.Vernut();
                foreach (Avtomobile i in a)
                {
                    pomit(i);
                }
            }
            if (p == 3)
            {
                return;
            }
            Thread.Sleep(1700);
            Console.Clear();
        }
    }
}
