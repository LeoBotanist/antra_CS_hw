using Classes.DataModel;

namespace Classes.Service.Interfaces;

public interface IInstructorService: IPersonService
{
    int CalculateYearsOfExperience(Instructor instructor);
    decimal GetBonusSalary(Instructor instructor);
}