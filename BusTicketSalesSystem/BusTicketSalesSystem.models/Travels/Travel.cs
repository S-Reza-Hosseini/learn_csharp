using BusTicketSalesSystem.models.Buses;


namespace BusTicketSalesSystem.models.Travels;


class Travel
{
    public Travel(
        string beginning,
        string destination,
        DateTime dateTravel,
        Bus bus)
    {
       Beginning = beginning;
       Destination= destination;
       DateTravel = dateTravel;
       Bus= bus;

       if (bus.Type == TypeBus.VIP)
           Fee = 100;
       else
           Fee = 50;
       
       Capacity = Bus.Capacity;
    }
    
    public string Beginning { get; } 
    public string Destination { get; } 
    public DateTime DateTravel { get; }
    public double Fee { get; private set; }
    public Bus Bus { get; }

    public int Capacity { get; set; }

    private readonly List<int> _passengers = new();

    public void AddPassenger(int customerNationalId)
    {
        
    }
}