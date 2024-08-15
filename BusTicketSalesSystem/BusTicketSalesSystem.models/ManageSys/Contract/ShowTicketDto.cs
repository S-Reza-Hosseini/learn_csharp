using BusTicketSalesSystem.models.Customers;

namespace BusTicketSalesSystem.models.ManageSys.Contract;

public class ShowTicketDto
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int NationalId { get; set; }
    public string PhoneNumber { get; set; }
    public string Beginning { get; set; }
    public string Destination { get; set; }
    public decimal Fee { get; set; }
}