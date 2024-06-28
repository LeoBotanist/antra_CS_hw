namespace Classes.DataModel;

public class Student: Person
{
    public List<Course> Courses { get; set; } = new List<Course>();

    public override decimal CalculateSalary()
    {
        return 0;
    }
    
}