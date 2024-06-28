namespace Generics;

public abstract class Entity
{
    public int Id { get; set; }
}

public class GenericRepository<T>: IRepository<T> where T : Entity
{
    private List<T> _repository = new List<T>();
    public void Add(T item)
    {
        _repository.Add(item);
    }

    public void Remove(T item)
    {
        _repository.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return _repository;
    }

    public T GetById(int id)
    {
        return _repository.FirstOrDefault(item => item.Id == id);
    }
}