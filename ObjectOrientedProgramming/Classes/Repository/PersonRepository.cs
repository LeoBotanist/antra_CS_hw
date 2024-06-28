using Classes.Repository.Interfaces;
using Classes.DataModel;

namespace Classes.Repository;

public class PersonRepository: IRepository<Person>
{
    private List<Person> _persons = new List<Person>();
    public int Insert(Person obj)
    {
        if (GetById(obj.Id) == null)
        {
            _persons.Add(obj);
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Update(Person obj)
    {
        Person p = GetById(obj.Id);
        if (p != null)
        {
            p.Id = obj.Id;
            p.Name = obj.Name;
            p.BirthDate = obj.BirthDate;
            p.Salary = obj.Salary;
            p.Addresses = obj.Addresses;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Person p = GetById(id);
        if (p != null)
        {
            _persons.Remove(p);
            return 1;
        }

        return 0;
    }

    public Person GetById(int id)
    {
        for (int i = 0; i < _persons.Count; i++)
        {
            if (_persons[i].Id == id)
            {
                return _persons[i];
            }
        }

        return null;
    }

    public List<Person> GetAll()
    {
        return _persons;
    }
}