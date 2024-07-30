using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
public class OfficialEmployee : Employee 
{
    public OfficialEmployee(string name , int id , int sabegheKar) 
    : base(name , id, sabegheKar)
    {
        SabegheKar = sabegheKar;
    }
    
    private int SabegheKar {get; set;}

    public double MohasebehHoghogh(int saatKari, double payeHoghogh)
    {
        return (((double)saatKari)*(double)SabegheKar)*(payeHoghogh) * 2.0 ;
    }
}