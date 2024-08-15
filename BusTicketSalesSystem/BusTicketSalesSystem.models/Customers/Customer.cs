namespace BusTicketSalesSystem.models.Customers;
using Tickets;

class Customer(
    string name,
    string family,
    int nationalId,
    string phoneNumber
    )
{
    public string Name { get; } = name;
    public string Family { get; } = family;
    public string PhoneNumber { get; } = phoneNumber;
    public int NationalId { get; } = nationalId;

    private readonly List<Ticket> _ticket = new();

    public void GetTicket(Ticket ticket)
    {
        _ticket.Add(ticket);
    }

}