namespace TrafficControl.Models.Vehicles;
using TrafficControl.Models.FineTicket;

 class Vehicle
{
    public Vehicle(string licensePlateNum,TypeCar vehicleType)
    {
        LicensePlateNum = licensePlateNum;
        VehicleType = vehicleType;
    }
    public string LicensePlateNum { get; }
    public TypeCar VehicleType { get; }

    private readonly List<TrafficViolation> _TotalViolatios = new();


    public void AddViolation(List<TrafficViolation> trafficViolation)
    {
        _TotalViolatios.AddRange(trafficViolation);
    }
}
 public enum TypeCar
 {
     PassengerCar = 1,
     HeavyVehicle = 2    
 } 