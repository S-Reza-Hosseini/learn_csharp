using TrafficControl.Models.Roads;
using TrafficControl.Models.Vehicles;


namespace TrafficControl.Models.Traffic;


class TrafficRegistration
{
    public TrafficRegistration(Road road,
        Vehicle vehicle,
        double speed)
    {
        Speed = speed;
        Vehicle = vehicle;
        Road = road;
        Detail = $"{road.StartAddress} to {road.EndAddress}";
    }
   public Road Road { set; get; }
   
   public Vehicle Vehicle { get; }
   
   private string Detail { get; }
   
   public double Speed { get; }
   
   
}
