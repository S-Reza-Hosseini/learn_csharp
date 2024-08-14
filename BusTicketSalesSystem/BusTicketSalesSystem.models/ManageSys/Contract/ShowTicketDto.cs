namespace BusTicketSalesSystem.models.ManageSys.Contract;

public class ShowTicketsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string PhoneNumber { get; set; }
    public string Beginning { get; set; }
    public string Destination { get; set; }
    public DateTime DateTime { get; set; }
    public double TotalPay { get; set; }
}