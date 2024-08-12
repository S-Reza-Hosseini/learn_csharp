namespace TrafficControl.Models.FineTicket;

public class TrafficViolation
{
    public TrafficViolation(string detail, string licensePlateNum, double fineAmount)
    {
        Detail = detail;
        LicensePlateNum = licensePlateNum;
        FineAmount = fineAmount;
    }
    public string Detail { get; set; }
    
    public string LicensePlateNum { get; set; }
    
    public double FineAmount { get; set; }
}