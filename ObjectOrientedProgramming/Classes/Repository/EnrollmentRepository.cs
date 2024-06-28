using Classes.Repository.Interfaces;
using Classes.DataModel;
using Classes.Service;

namespace Classes.Repository;

public class EnrollmentRepository: IEnrollmentRepository
{
    private List<Enrollment> _enrollments = new List<Enrollment>();
    public int Insert(Enrollment obj)
    {
        if (GetById(obj.Id) == null)
        {
            _enrollments.Add(obj);
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Update(Enrollment obj)
    {
        Enrollment p = GetById(obj.Id);
        if (p != null)
        {
            p.Id = obj.Id;
            p.Student = obj.Student;
            p.Course = obj.Course;
            p.Grade = obj.Grade;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Enrollment p = GetById(id);
        if (p != null)
        {
            _enrollments.Remove(p);
            return 1;
        }

        return 0;
    }

    public Enrollment GetById(int id)
    {
        for (int i = 0; i < _enrollments.Count; i++)
        {
            if (_enrollments[i].Id == id)
            {
                return _enrollments[i];
            }
        }

        return null;
    }

    public List<Enrollment> GetAll()
    {
        return _enrollments;
    }

    public List<Enrollment> GetEnrollmentsByStudent(Student student)
    {
        List<Enrollment> enrollments = new List<Enrollment>();
        foreach (var enrollment in _enrollments)
        {
            if (enrollment.Student.Equals(student))
            {
                enrollments.Add(enrollment);
            }
        }

        return enrollments;
    }

    public List<Enrollment> GetEnrollmentsByCourse(Course course)
    {
        List<Enrollment> enrollments = new List<Enrollment>();
        foreach (var enrollment in _enrollments)
        {
            if (enrollment.Course.Equals(course))
            {
                enrollments.Add(enrollment);
            }
        }

        return enrollments;
    }

    public List<Enrollment> GetEnrollmentsByDepartment(Department department)
    {
        List<Enrollment> enrollments = new List<Enrollment>();
        foreach (var enrollment in _enrollments)
        {
            if (enrollment.Department.Equals(department))
            {
                enrollments.Add(enrollment);
            }
        }

        return enrollments;
    }
}