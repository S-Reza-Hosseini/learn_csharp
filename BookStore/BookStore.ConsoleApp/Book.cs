public class Book 
{

    public string BookName {get; set;}

    public string BookAuthor {get;set;}

    public double BookPrice {get; set;}

    public string LendBook(string book, string customerName) =>
        $"Welcome. dear {customerName} now the {book} book is yours until 2 week. enjoy";


}  