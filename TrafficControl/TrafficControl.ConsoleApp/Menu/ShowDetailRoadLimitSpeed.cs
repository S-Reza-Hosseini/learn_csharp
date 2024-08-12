namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;
using static System.Console;

public class ShowDetailRoadsLimitSpeed
{
    public static void Run(Police police)
    {
        police.ShowDetailForHeavyVehicle();
    }
}