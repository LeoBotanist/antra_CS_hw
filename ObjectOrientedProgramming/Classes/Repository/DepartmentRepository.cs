using Classes.Repository.Interfaces;
using Classes.DataModel;

namespace Classes.Repository;

public class DepartmentRepository: IDepartmentRepository
{
    private List<Department> _departments = new List<Department>();
    public int Insert(Department obj)
    {
        if (GetById(obj.Id) == null)
        {
            _departments.Add(obj);
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Update(Department obj)
    {
        Department p = GetById(obj.Id);
        if (p != null)
        {
            p.Id = obj.Id;
            p.Name = obj.Name;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Department p = GetById(id);
        if (p != null)
        {
            _departments.Remove(p);
            return 1;
        }

        return 0;
    }

    public Department GetById(int id)
    {
        for (int i = 0; i < _departments.Count; i++)
        {
            if (_departments[i].Id == id)
            {
                return _departments[i];
            }
        }

        return null;
    }

    public Instructor GetDepartmentHead(Department department)
    {
        return department.Head;
    }

    public List<Department> GetAll()
    {
        return _departments;
    }

    public decimal GetBudget(Department department)
    {
        return department.Budget;
    }
    
}