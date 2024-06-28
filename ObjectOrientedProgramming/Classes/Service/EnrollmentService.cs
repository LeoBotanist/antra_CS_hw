using Classes.DataModel;
using Classes.Repository.Interfaces;
using Classes.Service.Interfaces;

namespace Classes.Service;

public class EnrollmentService: IEnrollmentService
{
    private IEnrollmentRepository _repository;

    public EnrollmentService(IEnrollmentRepository repository)
    {
        _repository = repository;
    }
    
    public void AddEnrollment(Enrollment enrollment)
    {
        _repository.Insert(enrollment);
    }

    public Enrollment GetEnrollmentById(int id)
    {
        return _repository.GetById(id);
    }

    public List<Enrollment> GetAllEnrollments()
    {
        return _repository.GetAll();
    }

    public List<Enrollment> GetEnrollmentsByStudent(Student student)
    {
        return _repository.GetEnrollmentsByStudent(student);
    }

    public List<Enrollment> GetEnrollmentsByCourse(Course course)
    {
        return _repository.GetEnrollmentsByCourse(course);
    }

    public List<Enrollment> GetEnrollmentsByDepartment(Department department)
    {
        return _repository.GetEnrollmentsByDepartment(department);
    }
}