// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Choice to execute required following Classes");
int choice = Convert.ToInt32(Console.ReadLine());
int number;
switch(choice)
{
    case 1:
        LogicalPrograms.FibonacciSeriesUc1 fibonacciSeries = new LogicalPrograms.FibonacciSeriesUc1();
        Console.WriteLine("Enter a number till which fibonacci series has to be printed");
        number = Convert.ToInt32(Console.ReadLine());
        fibonacciSeries.PrintFibonacciSeries(number);
        Console.WriteLine();
        break;
    case 2:
        LogicalPrograms.PerfectNumberUc2 perfectNumber =  new LogicalPrograms.PerfectNumberUc2();
        Console.WriteLine("Enter a number whther its Perfect number or not");
        number = Convert.ToInt32(Console.ReadLine());
        perfectNumber.CheckPerfectNumber(number);
        break;
    default:
        break;
}
