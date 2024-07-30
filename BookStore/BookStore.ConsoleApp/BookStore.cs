using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


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

    public List<Book> AddBook()
    {
        List <Book> Books = new List<Book>();

        int number  = GetNumber($"Enter number for adding book in BookStore {Name} :");

        for (int i = 0; i < number ; i++ ){

                Console.WriteLine($"Enter name of your Book {i+1} :");
                string nameBook = Console.ReadLine();

                Console.WriteLine($"Enter author name of your Book {nameBook} :");
                string authorBook= Console.ReadLine();

                Console.WriteLine($"Enter price for Book {nameBook}");
                double priceBook = double.Parse(Console.ReadLine());

                Books.Add(new Book {BookName = nameBook ,
                 BookAuthor = authorBook , BookPrice  = priceBook });
            
        }

        return Books;
    }

    public void sellBook(List<Book> Books)
    {

      Console.WriteLine("---------------------------------------------------------------");
      Console.WriteLine("Book list for sell ");

        foreach (var item in Books){

        Console.WriteLine(@$"
        ketab {item.BookName} nevisandeh {item.BookAuthor} ba gheimat {item.BookPrice} toman");
            
           
        }
       
    }

    private static int GetNumber(string msg)
    {
        bool canParseNumber = false;
        var number = 0;
        while(!canParseNumber)
        {
        Console.WriteLine(msg);
        canParseNumber = int.TryParse(Console.ReadLine(), out number);
        }
        return number;
    }


}

