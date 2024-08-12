using System.Diagnostics.Tracing;
using TrafficControl.Models.Vehicles;

namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;
using static System.Console;

public class RegesterVehicle
{
    public static void Run(Police police)
    {
        var licensePlateNum = GetUserStrInput("License Plate Number");
        var typeCar = GetUserIntInput("1 for passengerCar/2 for Heavy vehicle");
        switch (typeCar)
        {
            case 1 : police.RegesterVehicle(licensePlateNum,TypeCar.PassengerCar);break;
            case 2 : police.RegesterVehicle(licensePlateNum, TypeCar.HeavyVehicle);break;
           
        }
    }
    private static string GetUserStrInput(string msg)
    {
        Write($"Enter {msg} :");
        var input = ReadLine();

        if (input != null) return input;
        WriteLine($"{msg} is invalid !! . try again !");
        return GetUserStrInput(msg);
    }
    private static int GetUserIntInput(string msg)
    {
        var canParseNumber = false;
        var number = 0;
        while (!canParseNumber)
        {
            WriteLine($"Enter {msg} :");
            canParseNumber = int.TryParse(ReadLine(), out number);

            if (number != 1 && number != 2)
            {
                WriteLine($"{number} is invalid !! enter correct number again !");
                canParseNumber = false;
            }
        }

        return number;
    }
    
    
}