namespace Classes.DataModel;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Instructor CourseInstructor { get; set; }
}