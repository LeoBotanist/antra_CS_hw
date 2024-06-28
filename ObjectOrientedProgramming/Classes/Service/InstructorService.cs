using Classes.DataModel;
using Classes.Service.Interfaces;
using Classes.Repository;
using Classes.Repository.Interfaces;

namespace Classes.Service;

public class InstructorService: PersonService, IInstructorService
{
    private IPersonService _enrollmentService;
    public InstructorService(IRepository<Person> repository)
        : base(repository)
    {
    }

    public int CalculateYearsOfExperience(Instructor instructor)
    {
        return instructor.GetYearsOfExperience();
    }

    public decimal GetBonusSalary(Instructor instructor)
    {
        return instructor.GetBonusSalary();
    }
}