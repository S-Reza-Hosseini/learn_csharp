namespace BusTicketSalesSystem.models.ManageSys.Contract;

public class ShowTravelDto
{
    public int Id { get; set; }
    public string Beginning { get; set; } 
    public string Destination { get; set; } 
    public DateTime DateTravel { get; set; }
    public double Fee { get; set; }
    
    public int Capacity { get; set; }
     
}