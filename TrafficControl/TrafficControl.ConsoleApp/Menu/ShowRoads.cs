using TrafficControl.Models.TrafficPolice;

namespace TrafficControl.ConsoleApp.Menu;
using TrafficControl.Models.TrafficPolice;


public class ShowRoads
{
    public static void Run(Police police)
    {
        police.DisplayRoads();
    }
}