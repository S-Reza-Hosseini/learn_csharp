namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;
using static System.Console;

public class ReportTraffic
{
    public static void Run(Police police)
    {
        var roadId = GetUserIntInput("road Id ");
        var licensePlateNum = GetUserStrInput("License Plate Number");
        var speed = GetUserDoubleInput("speed");
        
        police.ReportTraffic(roadId,licensePlateNum,speed);
    }
    
    private static int GetUserIntInput(string msg)
    {
        var canParseNumber = false;
        int number = 0;
        while (!canParseNumber)
        {
            WriteLine($"Enter {msg} :");
            canParseNumber = int.TryParse(ReadLine(), out number);
            
        }

        return number;
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