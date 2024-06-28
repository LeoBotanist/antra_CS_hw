namespace Classes.DataModel;

public class Enrollment
{
    public int Id { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public char Grade { get; set; }
    
    public Department Department { get; set; }

    public int GetNeumericalGrade()
    {
        return Grade switch
        {
            'A' => 4,
            'B' => 3,
            'C' => 2,
            'D' => 1,
            _ => 0
        };
    }
}