using System.Dynamic;

class BookStore
{
    public BookStore(string name, string address, bool kafe, bool makanDengBrayeKetabKhani)
    {
        Name = name;
        Address = address;
        Kafe = kafe;
        MakanDengBrayeKetabKhani = makanDengBrayeKetabKhani;
    }
    public string Name { get; set;}

    public string Address {get; set;}

    public bool  Kafe {get; set;}

    public bool MakanDengBrayeKetabKhani {get; set;}


    public void Advicing(string customerName)
    {
        Console.WriteLine($"Welcom {customerName} to {Name} BookStore ");
    }

    int countNobat = 0;
    public void nobatDehiRoydadKetab(string name)
    {
        countNobat++;

        Console.WriteLine($"nobat {name} dar in roydad {countNobat} ast !!");
    }
}