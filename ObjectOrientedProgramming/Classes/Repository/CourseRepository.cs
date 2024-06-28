using Classes.Repository.Interfaces;
using Classes.DataModel;

namespace Classes.Repository;

public class CourseRepository: IRepository<Course>
{
    private List<Course> _courses = new List<Course>();
    public int Insert(Course obj)
    {
        if (GetById(obj.Id) == null)
        {
            _courses.Add(obj);
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Update(Course obj)
    {
        Course p = GetById(obj.Id);
        if (p != null)
        {
            p.Id = obj.Id;
            p.Name = obj.Name;
            p.CourseInstructor = obj.CourseInstructor;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Course p = GetById(id);
        if (p != null)
        {
            _courses.Remove(p);
            return 1;
        }

        return 0;
    }

    public Course GetById(int id)
    {
        for (int i = 0; i < _courses.Count; i++)
        {
            if (_courses[i].Id == id)
            {
                return _courses[i];
            }
        }

        return null;
    }

    public List<Course> GetAll()
    {
        return _courses;
    }
}