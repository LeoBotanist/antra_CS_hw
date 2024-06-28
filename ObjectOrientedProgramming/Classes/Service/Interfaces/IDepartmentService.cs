using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface IDepartmentService
{
    void AddDepartment(Department department);
    List<Department> GetAllDepartments();
    Department GetDepartmentById(int id);
    List<Course> GetCourses(Department department);
    Instructor GetDepartmentHead(Department department);
}