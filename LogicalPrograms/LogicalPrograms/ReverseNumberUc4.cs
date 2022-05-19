using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumberUc4
    {
        int remainder,reverse=0;
        public void Reverse(int number)
        {
            while(number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;

            }
            Console.WriteLine("Reversed Number is "+reverse);
        }
    }
}
