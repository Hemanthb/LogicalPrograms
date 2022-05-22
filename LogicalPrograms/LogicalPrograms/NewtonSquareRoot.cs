using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class NewtonSquareRoot
    {
        private static double root;
        public static void FindSquareRoot(int value)
        {
            root = value;
            while (Math.Abs(root - (value / root)) > Math.Pow(10, -15) * root)
            {
                root = (0.5 * (root + (value / root)));
                
            }
            Console.WriteLine("Square root of given number {0} is {1}",value,root);
        }
        
    }
}
