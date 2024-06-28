using Classes.DataModel;

namespace Classes.Repository.Interfaces;

public interface IEnrollmentRepository: IRepository<Enrollment>
{
    List<Enrollment> GetEnrollmentsByStudent(Student student);
    List<Enrollment> GetEnrollmentsByCourse(Course course);
    List<Enrollment> GetEnrollmentsByDepartment(Department department);
}