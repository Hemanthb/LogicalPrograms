// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Choice to execute required following Classes");
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
    case 0:
        LogicalPrograms.FibonacciSeriesUc1 fibonacciSeries = new LogicalPrograms.FibonacciSeriesUc1();
        Console.WriteLine("Enter a number till which fibonacci series has to be printed");
        int number = Convert.ToInt32(Console.ReadLine());
        fibonacciSeries.PrintFibonacciSeries(number);
        Console.WriteLine();
        break;
    default:
        break;
}
