using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

public class Employee
{
    public Employee(string name , int id, int sabegheKar)
    {
        EmployeeName = name;
        EmployeeId = id ;
        SabegheKar = sabegheKar;
    }

    public string EmployeeName {get; set;}
    public int EmployeeId {get; set;}
    public int SabegheKar{get; set;}


    public string CanEnterToOffice() => @$"Employee {EmployeeName} 
    with {EmployeeId} can Enter to office !!";
    

}