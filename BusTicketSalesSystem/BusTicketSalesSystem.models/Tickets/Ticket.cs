using BusTicketSalesSystem.models.Travels;

namespace BusTicketSalesSystem.models.Tickets;
using BusTicketSalesSystem.models.Customers;

class Ticket
{
    public Ticket(
        Customer customer,
        Travel travel,
        TypePay payMethod,
        decimal totalpay)
    {
        Customer = customer;
        Travel = travel;
        PayMethod = payMethod;
        TotalPay = totalpay;
    }
    public Customer Customer { get; }
    public Travel Travel { get;}
    public TypePay PayMethod { get;}
    public decimal TotalPay { get; }
    
    
    
}
public enum TypePay
{
    Sell = 1 ,
    Reserve =2,
}


