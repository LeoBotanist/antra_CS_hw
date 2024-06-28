namespace Classes.DataModel;

public class Instructor: Person
{
    public int Department { get; set; }
    public DateTime JoinDate { get; set; }
    
    public int GetYearsOfExperience()
    {
        return DateTime.Now.Year - JoinDate.Year;
    }
    
    public decimal GetBonusSalary()
    {
        return 1000 * GetYearsOfExperience();
    }
    
    public override decimal CalculateSalary()
    {
        return Salary + GetBonusSalary();
    }
    
    
    
}