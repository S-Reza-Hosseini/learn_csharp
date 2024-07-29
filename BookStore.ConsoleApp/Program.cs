// See https://aka.ms/new-console-template for more information


BookStore bookStore = new BookStore(name: "kafka" , address : "zand", 
                                    kafe : true , makanDengBrayeKetabKhani : false);

Console.WriteLine($"BookStore {bookStore.Name} in {bookStore.Address} is opened !!");

bookStore.Advicing("ali");

bookStore.nobatDehiRoydadKetab("ali");
List<Book> BookList = bookStore.AddBook();
bookStore.sellBook(BookList);