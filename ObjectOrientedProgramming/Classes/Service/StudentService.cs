using Classes.DataModel;
using Classes.Service.Interfaces;
using Classes.Repository;
using Classes.Repository.Interfaces;

namespace Classes.Service;

public class StudentService: PersonService, IStudentService
{
    private IEnrollmentService _enrollmentService;
    public StudentService(IRepository<Person> repository, IEnrollmentService enrollmentService)
        : base(repository)
    {
        _enrollmentService = enrollmentService;
    }
    
    
    public List<Enrollment> GetEnrollments(Student student)
    {
        return _enrollmentService.GetEnrollmentsByStudent(student);
    }

    public double CalculateGPA(Student student)
    {
        List<Enrollment> enrollments = GetEnrollments(student);
        return enrollments.Average(e => e.GetNeumericalGrade());
    }

    
}