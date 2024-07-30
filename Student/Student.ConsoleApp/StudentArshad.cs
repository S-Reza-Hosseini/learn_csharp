
public class StudentArshad: Student
{
    public StudentArshad(string name, int id, int enteringYear, double avg, bool isMashroot = false)
        : base(name, id, enteringYear, avg)
    {
        IsMashroot = isMashroot;
    }

    public bool IsMashroot { get; set; }

    public bool IsMashrootmethod() 
    {
        if (Avg < 14)
        {
            IsMashroot = true; 
            Console.WriteLine($"Student {Name} is mashroot!");
            return true;
        }
        else 
        {
            return false;
        }
    }
}
