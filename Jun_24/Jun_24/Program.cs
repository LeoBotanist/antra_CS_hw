// See https://aka.ms/new-console-template for more information

using System.Text;

internal class Program
{

    public static void TypeInfo()
    {
        Console.WriteLine($"Name: sbyte, number of bytes: {sizeof(sbyte)}, min value: {sbyte.MinValue}, max value: {sbyte.MaxValue}");
        Console.WriteLine($"Name: byte, number of bytes: {sizeof(byte)}, min value: {byte.MinValue}, max value: {byte.MaxValue}");
        Console.WriteLine($"Name: short, number of bytes: {sizeof(short)}, min value: {short.MinValue}, max value: {short.MaxValue}");
        Console.WriteLine($"Name: ushort, number of bytes: {sizeof(ushort)}, min value: {ushort.MinValue}, max value: {ushort.MaxValue}");
        Console.WriteLine($"Name: int, number of bytes: {sizeof(int)}, min value: {int.MinValue}, max value: {int.MaxValue}");
        Console.WriteLine($"Name: uint, number of bytes: {sizeof(uint)}, min value: {uint.MinValue}, max value: {uint.MaxValue}");
        Console.WriteLine($"Name: long, number of bytes: {sizeof(long)}, min value: {long.MinValue}, max value: {long.MaxValue}");
        Console.WriteLine($"Name: ulong, number of bytes: {sizeof(ulong)}, min value: {ulong.MinValue}, max value: {ulong.MaxValue}");
        Console.WriteLine($"Name: float, number of bytes: {sizeof(float)}, min value: {float.MinValue}, max value: {float.MaxValue}");
        Console.WriteLine($"Name: double, number of bytes: {sizeof(double)}, min value: {double.MinValue}, max value: {double.MaxValue}");
        Console.WriteLine($"Name: decimal, number of bytes: {sizeof(decimal)}, min value: {decimal.MinValue}, max value: {decimal.MaxValue}");
    }
    
    public static void CenturiesToOthers(int centuries = 1)
    {
        int years = 100 * centuries;
        double days = 365.242 * years;
        double hours = 24 * days;
        double minutes = 60 * hours;
        double seconds = 60 * minutes;
        double milliseconds = 1000 * seconds;
        double microseconds = 1000 * milliseconds;
        double nanoseconds = 1000 * microseconds;
        Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days" +
                          $" = {hours:F0} hours = {minutes:F0} minutes = {seconds:F0} seconds = {milliseconds:F0} milliseconds" +
                          $" = {microseconds:F0} microseconds = {nanoseconds:F0} nanoseconds");
    }
    
    public static void FizzBuzz()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 101; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                sb.Append("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                sb.Append("fizz");
            }
            else if (i % 5 == 0)
            {
                sb.Append("buzz");
            }
            else
            {
                sb.Append(i);
            }

            if (i != 100)
            {
                sb.Append(' ');
            }
        }

        Console.WriteLine(sb);
    }
    
    public static void PrintPyramid(int levels)
    {
        int lengthOfLine = 2 * levels - 1;
        for (int i = 0; i < levels; i++)
        {
            StringBuilder currentLine = new StringBuilder();
            int lengthOfStars = 2 * i + 1;
            for (int j = 0; j < lengthOfLine; j++)
            {
                if (j < (lengthOfLine - lengthOfStars) / 2 ||
                    j >= (lengthOfLine + lengthOfStars) / 2)
                {
                    currentLine.Append(' ');
                }
                else
                {
                    currentLine.Append('*');
                }
            }

            Console.WriteLine(currentLine);
        }
    }

    public static void GuessNumber()
    {
        Random rnd = new Random();
        int result = rnd.Next(1, 4);
        Console.WriteLine("Please type your guess between 1 and 3");
        int userGuess = int.Parse(Console.ReadLine());
        if (userGuess < 1 || userGuess > 3)
        {
            Console.WriteLine("Guessed number is out of range!");
        }
        else
        {
            if (userGuess == result)
            {
                Console.WriteLine("Correct!");
            }
            else if (userGuess < result)
            {
                Console.WriteLine("Low!");
            }
            else
            {
                Console.WriteLine("High!");
            }
        }
    }

    public static void BirthDateCal(int year=1965, int month=02, int day=14)
    {
        DateTime birthDate = new DateTime(year, month, day);
        DateTime currentDate = DateTime.Now;
        int ageInDays = (currentDate - birthDate).Days;
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        Console.WriteLine($"Birth date is {birthDate.ToShortDateString()}");
        Console.WriteLine($"Age in days is {ageInDays}");
        Console.WriteLine($"Days to next anniversary is {daysToNextAnniversary} days");
    }

    public static void Greetings()
    {
        int currentHour = DateTime.Now.Hour;
        Console.WriteLine(currentHour);
        if (currentHour <= 6 || currentHour > 20)
        {
            Console.WriteLine("Good Night");
        }

        if (currentHour > 6 && currentHour <= 12)
        {
            Console.WriteLine("Good Morning");
        }
        
        if (currentHour > 12 && currentHour <= 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        
        if (currentHour > 18 && currentHour <= 20)
        {
            Console.WriteLine("Good Evening");
        }
    }

    public static void CountingTo24()
    {
        for (int i = 0; i < 4; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j <= 24; j +=  i + 1)
            {
                sb.Append(j);
                if (j != 24)
                {
                    sb.Append(',');
                }
            }

            Console.WriteLine(sb);
        }
    }

    
    public static void Main(string[] args)
    {
        // TypeInfo();
        // CenturiesToOthers(5);
        // FizzBuzz();
        // PrintPyramid(6);
        // GuessNumber();
        // BirthDateCal();
        // Greetings();
        // CountingTo24();
    }
    
}
