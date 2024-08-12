using Microsoft.VisualBasic;

namespace TrafficControl.Models.TrafficPolice.Tools;

public interface IPoliceIo
{
    void Write(string msg);

    void WriteLine(string msg);

    void Clear();

    string ReadLine();

}