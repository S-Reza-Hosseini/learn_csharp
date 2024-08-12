namespace TrafficControl.Models.Roads;

class Road
{
    public Road(string startAddress,
                string endAddress,
                double speedLimitHeavyVehicle,
                double speedLimitPassengerCar)
        {
        StartAddress = startAddress;
        EndAddress = endAddress;
        SpeedLimitHeavyVehicle = speedLimitHeavyVehicle;
        SpeedLimitPassengerCar = speedLimitPassengerCar;
    }
    
    public string StartAddress { get; }
    
    public string EndAddress { get; }
    
    public double SpeedLimitHeavyVehicle { get; }
    
    public double SpeedLimitPassengerCar { get; }

    public string reportRoad()
    {
        return $"road {StartAddress} to {EndAddress}" +
               $"with speed Limit for Heavy vehicle is {SpeedLimitHeavyVehicle}" +
               $"and speed Limit for Passenger Car is {SpeedLimitPassengerCar}";
    }
    
}