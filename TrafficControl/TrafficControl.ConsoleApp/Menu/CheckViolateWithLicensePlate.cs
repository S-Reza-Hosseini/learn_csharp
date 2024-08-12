namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;
using TrafficControl.Models.FineTicket;
using static System.Console;

public class CheckViolateWithLicensePlate
{
    public static void Run(Police police)
    {
        var licensePlateNum = GetUserStrInput("License Plate Number");

       List<TrafficViolation> violateCar= police.CheckViolation(licensePlateNum);
    }
    
    private static string GetUserStrInput(string msg)
    {
        Write($"Enter {msg} :");
        var input = ReadLine();

        if (input != null) return input;
        WriteLine($"{msg} is invalid !! . try again !");
        return GetUserStrInput(msg);
    }
}