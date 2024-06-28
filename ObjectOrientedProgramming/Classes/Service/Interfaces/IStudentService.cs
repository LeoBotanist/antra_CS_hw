using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface IStudentService: IPersonService
{
    List<Enrollment> GetEnrollments(Student student);
    double CalculateGPA(Student student);
}