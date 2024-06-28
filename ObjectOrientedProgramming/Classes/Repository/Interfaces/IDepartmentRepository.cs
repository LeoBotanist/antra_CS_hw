using Classes.DataModel;

namespace Classes.Repository.Interfaces;

public interface IDepartmentRepository: IRepository<Department>
{
    Instructor GetDepartmentHead(Department department);
    decimal GetBudget(Department department);
}