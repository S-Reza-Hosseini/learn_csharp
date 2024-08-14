using BusTicketSalesSystem.models.Buses;

namespace BusTicketSalesSystem.models.ManageSys.Contract;

public class ShowBusDto
{
    public int Id { get; set; }
    public string LicensePlate { get; set; }
    public TypeBus Type { get; set; }
}
