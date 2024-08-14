using BusTicketSalesSystem.models.Buses;


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
    public decimal Fee { get; private set; }
    public Bus Bus { get; }

    public int Capacity { get; set; }
    
}