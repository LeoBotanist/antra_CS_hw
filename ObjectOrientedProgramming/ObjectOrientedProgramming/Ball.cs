namespace ObjectOrientedProgramming;

public class Ball
{
    private Color color;
    private int size;
    private int throwTimes = 0;
    

    public Ball(Color color, int size)
    {
        this.color = color;
        this.size = size;
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size != 0)
        {
            throwTimes += 1;
        }
    }

    public int GetThrowTimes()
    {
        return throwTimes;
    }
    
}