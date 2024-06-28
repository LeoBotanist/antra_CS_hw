using Classes.DataModel;
using Classes.Repository.Interfaces;
using Classes.Service.Interfaces;

namespace Classes.Service;

public class DepartmentService: IDepartmentService
{
    private IDepartmentRepository _repository;
    private IEnrollmentService _enrollmentService;

    public void AddDepartment(Department department)
    {
        throw new NotImplementedException();
    }

    public List<Department> GetAllDepartments()
    {
        throw new NotImplementedException();
    }

    public Department GetDepartmentById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetCourses(Department department)
    {
        return _enrollmentService.GetEnrollmentsByDepartment(department).ConvertAll(e => e.Course);

    }

    public Instructor GetDepartmentHead(Department department)
    {
        return department.Head;
    }
}