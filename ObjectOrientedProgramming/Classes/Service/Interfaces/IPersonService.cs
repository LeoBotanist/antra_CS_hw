using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface IPersonService
{
    void AddPerson(Person person);
    List<Person> GetAllPersons();
    Person GetPersonById(int id);
    int CalculateAge(Person person);
    decimal CalculateSalary(Person person);
    List<string> GetAddresses(Person person);
}