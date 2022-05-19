using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeriesUc1
    {
        int c,a = 0,b = 1;
        public void PrintFibonacciSeries(int num)
        {
            Console.WriteLine("Fibonacci Series is -");
            Console.Write(a + " " + b + " ");
            for(int i = 0; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c+" ");
            }
        }
        

    }
}
