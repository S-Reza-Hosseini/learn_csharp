using System.ComponentModel.Design;
using TrafficControl.Models.Roads;
using TrafficControl.Models.Vehicles;
using TrafficControl.Models.Traffic;
using TrafficControl.Models.TrafficPolice.Tools;
using TrafficControl.Models.FineTicket;
using TrafficControl.Models.TrafficPolice.Contracts;


namespace TrafficControl.Models.TrafficPolice;

public class Police
{
    private readonly IPoliceIo _io;

    public Police(IPoliceIo io)
    {
        this._io = io;
    }


    private readonly List<Vehicle> _Vehicles = new();
    private readonly List<Road> _Roads = new();
    private readonly List<TrafficRegistration> _Traffics = new();
    private readonly List<TrafficViolation> _Violations = new();

    public void RegesterVehicle(string licensePlateNum, TypeCar vehicleType)
    {
        if (_Vehicles.Any(_ => _.LicensePlateNum == licensePlateNum))
            return;
        _Vehicles.Add(new Vehicle(licensePlateNum, vehicleType));
        _io.WriteLine("Done!!");
    }

    public void RegisterRoad(string start, string end,
        double speedLimitHeavyVehicle, double speedLimitPassengerCar)
    {
        if (_Roads.Any(_ => _.StartAddress.ToStandard() == start.ToStandard() &&
                            _.EndAddress.ToStandard() == end.ToStandard()))
            return;
        _Roads.Add(new Road(start, end, speedLimitHeavyVehicle, speedLimitPassengerCar));
        _io.WriteLine("Done!!");
    }

    public void ReportTraffic(int roadId, string licensePlateNum, double speed)
    {
        var road = _Roads[roadId - 1];

        Vehicle? vehicle = _Vehicles.Find(_ => _.LicensePlateNum.ToStandard() ==
                                               licensePlateNum.ToStandard());
        _Traffics.Add(new TrafficRegistration(road, vehicle, speed));
        _io.WriteLine("Done!!");
        GetViolation(road, vehicle, speed);
    }

    private void GetViolation(Road road, Vehicle vehicle, double speed)
    {
        var fine = 0.0;
        string detail;
        if (vehicle.VehicleType == TypeCar.PassengerCar
            && speed > road.SpeedLimitPassengerCar)
        {
            fine = PenaltyCalculation(speed - road.SpeedLimitPassengerCar);
            detail = $"{road.StartAddress} to {road.EndAddress}";
            _Violations.Add(new TrafficViolation(detail, vehicle.LicensePlateNum
                , fine));
            _io.WriteLine("takhalof sorat gerft !!");
        }

        if (vehicle.VehicleType == TypeCar.HeavyVehicle
            && speed > road.SpeedLimitHeavyVehicle)
        {
            fine = PenaltyCalculation(speed - road.SpeedLimitHeavyVehicle);
            detail = $"{road.StartAddress} to {road.EndAddress}";
            _Violations.Add(new TrafficViolation(detail, vehicle.LicensePlateNum
                , fine));
            _io.WriteLine("takhalof sorat gerft !!");
        }
    }

    public List<TrafficViolation> CheckViolation(string licensePlateNum)
    {
        var violations = _Violations
            .Where(_ => _.LicensePlateNum.ToStandard()
                        == licensePlateNum.ToStandard())
            .ToList();
        if (violations.Count == 0)
            _io.WriteLine("for this License not existance violate !!");
        else
        {
            foreach (var trafficViolate in violations)
            {
                _io.WriteLine($"in road{trafficViolate.Detail}" +
                              $"with {trafficViolate.LicensePlateNum}" +
                              $"and {trafficViolate.FineAmount} toman");
            }
        }

        return violations;
    }

    public List<ShowRoadDto> ShowRoads()
    {
        return _Roads.Select((road, index) => new ShowRoadDto()
        {
            Id = index + 1,
            Start = road.StartAddress,
            End = road.EndAddress,
            SpeedLimitPassengerCar = road.SpeedLimitPassengerCar,
            SpeedLimitHeavyVehicle = road.SpeedLimitHeavyVehicle,
        }).ToList();
    }


    // Display the roads in a user-friendly format
    public void DisplayRoads()
    {
        List<ShowRoadDto> roadsDto = ShowRoads();

        if (roadsDto.Count == 0)
        {
            _io.WriteLine("No roads registered yet.");
        }
        else
        {
            _io.WriteLine("Registered Roads:");
            foreach (ShowRoadDto road in roadsDto)
            {
                _io.WriteLine($"Road ID: {road.Id}," +
                              $" Start: {road.Start}," +
                              $" End: {road.End}," +
                              $" Speed Limit (Heavy Vehicle):" +
                              $" {road.SpeedLimitHeavyVehicle}," +
                              $" Speed Limit (Passenger Car):" +
                              $" {road.SpeedLimitPassengerCar}");
            }
        }
    }

    private static double PenaltyCalculation(double ExceedingSpeedLimit)
    {
        if (ExceedingSpeedLimit > 0 && ExceedingSpeedLimit <= 10)
            return 100000;
        if (ExceedingSpeedLimit > 10 && ExceedingSpeedLimit <= 20)
            return 150000;
        if (ExceedingSpeedLimit > 20 && ExceedingSpeedLimit <= 30)
            return 300000;

        return 300000;
    }

    public void ShowDetailForHeavyVehicle()
    {
        foreach (var road in _Roads
                     .Where(_ => _.SpeedLimitHeavyVehicle < 60)
                     .Select(_ => new
                     {
                         Start = _.StartAddress,
                         End = _.EndAddress
                     }))
        {
            _io.WriteLine($"{road.Start} and {road.End}");
        }
    }
}