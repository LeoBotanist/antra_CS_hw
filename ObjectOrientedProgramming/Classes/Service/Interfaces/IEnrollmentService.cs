using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface IEnrollmentService
{
    void AddEnrollment(Enrollment enrollment);
    List<Enrollment> GetAllEnrollments();
    Enrollment GetEnrollmentById(int id);
    List<Enrollment> GetEnrollmentsByStudent(Student student);
    List<Enrollment> GetEnrollmentsByCourse(Course course);
    List<Enrollment> GetEnrollmentsByDepartment(Department department);
    
}