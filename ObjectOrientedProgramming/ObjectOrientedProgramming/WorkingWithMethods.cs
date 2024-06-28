namespace ObjectOrientedProgramming;

public static class WorkingWithMethods
{
    public static int[] GenerateNumbers(int length=10)
    {
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = i;
        }

        return result;
    }

    public static void Reverse(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            (arr[i], arr[length - 1 - i]) = (arr[length - 1 - i], arr[i]);
        }
    }

    public static void PrintNumbers(int[] arr)
    {
        Console.WriteLine("Reversed array: " +
                          string.Join(", ", arr));
    }

    public static int Fibonacci(int length)
    {
        if (length == 1)
        {
            return 0;
        } else if (length == 2)
        {
            return 1;
        }
        else
        {
            int left = 1;
            int right = 1;
            for (int i = 3; i < length; i++)
            {
                (left, right) = (right, left + right);
            }

            return right;
        }
    }
}