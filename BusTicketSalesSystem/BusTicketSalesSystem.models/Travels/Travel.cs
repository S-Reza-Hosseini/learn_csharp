using BusTicketSalesSystem.models.Buses;
using BusTicketSalesSystem.models.Tickets;


namespace BusTicketSalesSystem.models.Travels;


class Travel
{
    public Travel(
        string beginning,
        string destination,
        DateTime dateTravel,
        decimal fee,
        Bus bus)
    {
       Beginning = beginning;
       Destination= destination;
       DateTravel = dateTravel;
       Bus= bus;
       Fee = fee;
       Capacity = Bus.Capacity;
    }
    
    public string Beginning { get; } 
    public string Destination { get; } 
    public DateTime DateTravel { get; }
    public decimal Fee { get; set; }
    public Bus Bus { get; }

    public int Capacity { get; private set; }

    private readonly List<Ticket> _tickets = new();

    public void AddTicket(Ticket ticket)
    {
        _tickets.Add(ticket);
        Capacity -= 1;
    }
    public void RemoveTicket(Ticket ticket)
    {
        _tickets.Remove(ticket);
        Capacity += 1;
    }

}