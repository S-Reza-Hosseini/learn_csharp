namespace BusTicketSalesSystem.models.Buses;

class Bus
{
    public Bus(string licensePlate, TypeBus type)
    {
     LicensePlate= licensePlate;
     Type = type;
     
     
     if (type == TypeBus.VIP)
         Capacity = 23;
     else
         Capacity = 44;

    }
    
    public TypeBus Type { get; }
    public string LicensePlate { get; }
    public int Capacity { get; private set; }

    public decimal Income { get; set; } = 0;
    
}

public enum TypeBus
{
    VIP = 1,
    Normal,
}