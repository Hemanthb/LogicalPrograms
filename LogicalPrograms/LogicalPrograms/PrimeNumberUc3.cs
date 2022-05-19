using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumberUc3
    {
        public void CheckPrime(int number)
        {
            int count = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    count++;
                    Console.WriteLine("{0} isn't a Prime Number",number);
                    break;
                    
                }
            }
            if(count == 0)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
        }
    }
}
