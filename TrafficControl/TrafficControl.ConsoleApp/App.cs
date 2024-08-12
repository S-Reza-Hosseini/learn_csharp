using System.Xml;
using TrafficControl.Models.TrafficPolice;
using TrafficControl.ConsoleApp.console;
using TrafficControl.ConsoleApp.Menu;
using static System.Console;

namespace TrafficControl.ConsoleApp;


public class App
{
    public static void Run()
    {
        ConsolePoliceIo policeIo = new ConsolePoliceIo();
        Police police = new(policeIo);

        WriteLine("Hello Comrade");

        var workAgain = true;

        while (workAgain)
        {
            ShowMenu();
            var Choise = int.Parse(ReadLine());
            switch (Choise)
            {
                case 1 : RegesterVehicle.Run(police); break;
                case 2 : RegesterRoad.Run(police); break;
                case 3 : ShowRoads.Run(police);
                    ReportTraffic.Run(police); break;
                case 4 : ShowRoads.Run(police); break;
                case 5 : CheckViolateWithLicensePlate.Run(police); break;
                case 6 : workAgain = false; break;
                default : WriteLine("invalid choice. try again"); break;
            }
            
        }

    }
    
    
    
    private static void ShowMenu()
    {
        Write(@"
    Please choose number of action? 

    [1]. Register Vehicle
    [2]. Register Road
    [3]. Report Traffic
    
    [4]. Show Roads
    [5]. check Violate with licensePlateNum
    [6]. Exit

    My Choice is : ");
    }
}

    
    