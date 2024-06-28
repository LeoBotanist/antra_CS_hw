namespace Classes.DataModel;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}