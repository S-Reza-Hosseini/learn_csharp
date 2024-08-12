namespace TrafficControl.ConsoleApp.console;
using TrafficControl.Models.TrafficPolice.Tools;

public class ConsolePoliceIo : IPoliceIo
{
    public void Write(string msg)
    {
        Write(msg);
    }

    public void WriteLine(string msg)
    {
        WriteLine(msg);
    }

    public void Clear()
    {
        Console.Clear();
    }

    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}