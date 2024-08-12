namespace TrafficControl.Models.TrafficPolice.Contracts;

public record ShowRoadDto
{
    public int Id { get; set; }
    public string Start { get; set; }
    public string End { get; set; }
    public double SpeedLimitHeavyVehicle { get; set; }
    public double SpeedLimitPassengerCar { get; set; }
}