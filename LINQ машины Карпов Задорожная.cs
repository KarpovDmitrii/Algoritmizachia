class Avtomobile
{
    public string marka;
    public string color;
    public int nomer;
    
    public Avtomobile(string marka, string color, int nomer)
    {
        this.marka = marka;
        this.nomer = nomer;
        this.color = color;
    }
    public void Deconstruct(out string avtomarka, out int avtonomer, out string avtocolor)
    {
        avtomarka = marka;
        avtonomer = nomer;
        avtocolor = color;
    }
}
class Vladelci
{
    public string fio;
    public int [] nomer;
    
    public Vladelci(string fio, int [] nomer)
    {
        this.fio = fio;
        this.nomer = nomer;
    }
    public void Deconstruct(out string afio, out int [] anomer)
    {
        afio = fio;
        anomer = nomer;

    }
}

class Programm
{
    static void Main()
    {
        List<Avtomobile> garag = new List<Avtomobile>() ;
        garag.Add(new Avtomobile("Toyota", "yellow", 1234));
        garag.Add(new Avtomobile("Toyota", "green", 123));
        garag.Add(new Avtomobile("Lada", "blue", 12));
        garag.Add(new Avtomobile("Daewoo", "pink", 1));

        var selectMarka = from avto in garag
            where avto.marka == "Toyota"
            select avto;
        Console.WriteLine("автомобили марки Toyota");
        foreach (var avto in selectMarka)
        {
            Console.WriteLine($"{avto.marka},{avto.color}, {avto.nomer}");
        }
        
        List<Vladelci> avtoclub = new List<Vladelci>() ;
        avtoclub.Add(new Vladelci("TAOJAN" ,  new int [] {1,1234,123}));
        avtoclub.Add(new Vladelci("JAPJAN" ,  new int [] {12,1}));
        avtoclub.Add(new Vladelci("VAGJAN" ,  new int [] {12, 1,1234}));
        avtoclub.Add(new Vladelci("LONJAN" ,  new int [] {123,12}));
        foreach (var avto in garag)
        {
            int nomer = avto.nomer;
            var selectJanFromNomer = from vlad in avtoclub
                where vlad.nomer.Contains(nomer)
                select vlad;
            Console.WriteLine($"владельцы машины с номером {nomer}:");
            foreach (var vlad in selectJanFromNomer)
            {
                Console.WriteLine($"{vlad.fio}");
            }
        }

    }
}