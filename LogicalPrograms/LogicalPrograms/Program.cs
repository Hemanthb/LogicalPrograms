﻿// See https://aka.ms/new-console-template for more information
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
        Console.WriteLine("Enter a number to check whther its Perfect number or not");
        number = Convert.ToInt32(Console.ReadLine());
        perfectNumber.CheckPerfectNumber(number);
        break;
    case 3:
        LogicalPrograms.PrimeNumberUc3 primeNumber= new LogicalPrograms.PrimeNumberUc3();
        Console.WriteLine("Enter a number to check whther its Prime number or not");
        number = Convert.ToInt32(Console.ReadLine());
        primeNumber.CheckPrime(number);
        break;
    case 4:
        LogicalPrograms.ReverseNumberUc4 reverse = new LogicalPrograms.ReverseNumberUc4();
        Console.WriteLine("Enter a number to reverse it");
        number = Convert.ToInt32(Console.ReadLine());
        reverse.Reverse(number);
        break;
    case 5:
        LogicalPrograms.CouponNumberUc5 couponNumber = new LogicalPrograms.CouponNumberUc5();
        Console.WriteLine("Enter no of coupons code required to be generated");
        number = Convert.ToInt32(Console.ReadLine());
        couponNumber.GenerateCoupon(number);
        break;
    case 6:
        LogicalPrograms.StopWatchUc6 stopWatch = new LogicalPrograms.StopWatchUc6();
        stopWatch.CalculateTime();
        break;
    case 9:
        LogicalPrograms.TempConversionUc9 temp = new LogicalPrograms.TempConversionUc9();
        Console.WriteLine("Enter the temperature to convert");
        Double temperature = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter C for celsius and F for fahrenheit");
        Char degree =Convert.ToChar(Console.ReadLine());
        temp.ConvertTemperatureUnit(temperature, degree);
        break;
    default:
        break;
}
