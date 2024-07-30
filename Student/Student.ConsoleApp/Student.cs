using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

public class Student 
{
    public Student(string name , int id , int enteringYear, double avg )
    {
        Name = name;
        Id = id;
        EnteringYear = enteringYear;
        Avg = avg;
    }

    public string Name {get; set;}
    public int Id {get; set;}
    public int EnteringYear {get; set;}
    public double Avg {get; set;}


    public void Study()
    {
        Console.WriteLine($"The {Name} is Studing !");
    }


    }