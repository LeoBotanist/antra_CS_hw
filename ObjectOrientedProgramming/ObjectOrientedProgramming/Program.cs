// See https://aka.ms/new-console-template for more information

using ObjectOrientedProgramming;

int[] numbers = WorkingWithMethods.GenerateNumbers(15);
WorkingWithMethods.Reverse(numbers);
WorkingWithMethods.PrintNumbers(numbers);

int fibonacciLength = 10;

Console.WriteLine("Fibonacci: " + 
                  string.Join(", ", Enumerable.Range(1, fibonacciLength).Select(WorkingWithMethods.Fibonacci)));


int numberOfBalls = 10;

List<Ball> ballsList = new List<Ball>();
for (int i = 0; i < numberOfBalls; i++)
{
    ballsList.Add(new Ball(new Color(), i+1));
}

ballsList.ForEach(ball => ball.Throw());
Console.WriteLine("throw times before popping: " + 
                  string.Join(", ", ballsList.ConvertAll(ball => ball.GetThrowTimes())));

ballsList[3].Pop();
ballsList[6].Pop();
ballsList[9].Pop();

ballsList.ForEach(ball => ball.Throw());
Console.WriteLine("throw times after popping: " + 
                  string.Join(", ", ballsList.ConvertAll(ball => ball.GetThrowTimes())));

