using Classes.Repository.Interfaces;
using Classes.Service.Interfaces;

namespace Classes.Service;
using Classes.Repository;
using Classes.DataModel;

public class PersonService: IPersonService
{
    private IRepository<Person> _repository;

    public PersonService(IRepository<Person> repository)
    {
        _repository = repository;
    }

    public void AddPerson(Person p)
    {
        _repository.Insert(p);
    }

    public List<Person> GetAllPersons()
    {
        return _repository.GetAll();
    }

    public Person GetPersonById(int id)
    {
        return _repository.GetById(id);
    }

    public List<string> GetAddresses(Person person)
    {
        return person.GetAddresses();
    }

    public int CalculateAge(Person person)
    {
        return person.CalculateAge();
    }

    public decimal CalculateSalary(Person person)
    {
        return person.CalculateSalary();
    }
    
}