namespace Generics;

public class MyList<T>
{
    private List<T> myList = new List<T>();

    public void Add(T element)
    {
        myList.Add(element);
    }

    public T Remove(int index)
    {
        T item = myList[index];
        myList.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return myList.Contains(element);
    }

    public void Clear()
    {
        myList.Clear();
    }

    public void InsertAt(T element, int index)
    {
        myList.Insert(index, element);
    }
    
    public void DeleteAt(int index)
    {
        myList.RemoveAt(index);
    }

    public T Find(int index)
    {
        return myList[index];
    }
}