class Obob<T>
{
    public List<T> mas;
    public Obob()
    {
        this.mas = new List<T>();
    }
    public void Addmas(T element)
    {
        mas.Add(element);
    }
    public void Return()
    {
        foreach (T element in mas)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
    public T ElemInd(int ind)
    {
        return mas[ind];
    }
    public void Delete(T element)
    {
        mas.Remove(element);
    }
}
class Program
{
    static void Main()
    {
        int index = 2;
        Console.WriteLine("массив int");
        Obob<int> masi = new Obob<int>();
        masi.Addmas(1);
        masi.Addmas(4);
        masi.Addmas(8);
        masi.Return();
        Console.WriteLine($"Элемент с индексом 2: {masi.ElemInd(index)}");
        Console.WriteLine("Удалить элемент 4");
        masi.Delete(4);
        masi.Return();

        Console.WriteLine("массив string");
        Obob<string> mass = new Obob<string>();
        mass.Addmas("Горох");
        mass.Addmas("Чашка");
        mass.Addmas("Рулетка");
        mass.Return();
        Console.WriteLine($"Элемент с индексом 2: {mass.ElemInd(index)}");
        Console.WriteLine("Удалить элемент Горох");
        mass.Delete("Горох");
        mass.Return();
    }

}