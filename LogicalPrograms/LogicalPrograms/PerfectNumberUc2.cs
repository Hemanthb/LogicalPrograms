using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumberUc2
    {
        int sum = 0;
        public void CheckPerfectNumber(int number)
        {
            for (int i = 1; i <= (number/2); i++)
            {
                if(number%i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("{0} is a Perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} isn't a Perfect number", number);
            }
        }
    }
}
