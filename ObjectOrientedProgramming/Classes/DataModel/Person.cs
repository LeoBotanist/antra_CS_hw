namespace Classes.DataModel;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    public List<string> Addresses { get; set; } = new List<string>();

    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public abstract decimal CalculateSalary();

    public List<string> GetAddresses()
    {
        return Addresses;
    }
    

}