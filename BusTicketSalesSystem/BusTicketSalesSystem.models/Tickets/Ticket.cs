namespace BusTicketSalesSystem.models.Tickets;

public class Ticket
{
    public Ticket(
        string name,
        string family,
        int nationalId,
        string phoneNumber,
        string beginning,
        string destination,
        DateTime dateTime,
        TypePay payMethod,
        double totalpay)
    {
        Name = name;
        Family = family;
        NationalId = nationalId;
        PhoneNumber = phoneNumber;
        Beginning = beginning;
        Destination = destination;
        DateTime = dateTime;
        PayMethod = payMethod;
        TotalPay = totalpay;
    }
    public string Name { get;}
    public string Family { get;}
    
    public int NationalId { get; }
    public string PhoneNumber { get;}
    public string Beginning { get;}
    public string Destination { get;}
    public DateTime DateTime { get; }
    public TypePay PayMethod { get; set; }
    
    public double TotalPay { get; }
    
    
    
}
public enum TypePay
{
    Sell = 1 ,
    Reserve =2,
}


