using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface ICourseService
{
    void AddCourse(Course course);
    List<Course> GetAllCourses();
    Course GetCourseById(int id);
}