namespace Generics;

public class MyStack<T>
{
    private List<T> myStack = new List<T>();

    public int Count()
    {
        return myStack.Count;
    }

    public T Pop()
    {
        if (myStack.Count == 0)
        {
            throw new InvalidOperationException("stack is already empty!");
        }

        T last = myStack[myStack.Count - 1];
        myStack.RemoveAt(myStack.Count - 1);
        return last;
;    }

    public void Push(T toPush)
    {
        myStack.Add(toPush);
    }
}