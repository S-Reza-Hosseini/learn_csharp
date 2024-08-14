namespace BusTicketSalesSystem.models.Tickets;
using BusTicketSalesSystem.models.Customers;

class Ticket
{
    public Ticket(
        Customer customer,
        string beginning,
        string destination,
        DateTime dateTime,
        TypePay payMethod,
        decimal totalpay)
    {
        Customer = customer;
        Beginning = beginning;
        Destination = destination;
        DateTime = dateTime;
        PayMethod = payMethod;
        TotalPay = totalpay;
    }
    public Customer Customer { get; }
    public string Beginning { get;}
    public string Destination { get;}
    public DateTime DateTime { get; }
    public TypePay PayMethod { get; set; }
    
    public decimal TotalPay { get; }
    
    
    
}
public enum TypePay
{
    Sell = 1 ,
    Reserve =2,
}


