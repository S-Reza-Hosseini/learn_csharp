namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;
using static System.Console;

public class RegesterRoad
{
    public static void Run(Police police)
    {
        var startAddress = GetUserStrInput("start Address");
        var endAddress = GetUserStrInput("End Address");

        var speedLimitHeavyVehicle = GetUserDoubleInput("speed Limit for " +
                                                        "Heavy Vehicle");
        var speedLimitPassengerCar = GetUserDoubleInput("speed Limit for " +
                                                        "Passenger Car");
        
        police.RegisterRoad(startAddress,endAddress,speedLimitHeavyVehicle,
            speedLimitPassengerCar);
        
    }

    private static string GetUserStrInput(string msg)
    {
        Write($"Enter {msg} :");
        var input = ReadLine();

        if (input != null) return input;
        WriteLine($"{msg} is invalid !! . try again !");
        return GetUserStrInput(msg);
    }

    private static double GetUserDoubleInput(string msg)
    {
        var canParseNumber = false;
        var number = 0.0;
        while (!canParseNumber)
        {
            WriteLine($"Enter {msg} :");
            canParseNumber = double.TryParse(ReadLine(), out number);
            
        }

        return number;
    }
}