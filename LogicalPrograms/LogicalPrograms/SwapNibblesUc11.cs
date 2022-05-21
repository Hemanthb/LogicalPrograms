using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SwapNibblesUc13
    {
        public void SwapNibbles(int number)
        {
            String number1 = Convert.ToString(number,2).PadLeft(8,'0');
            Console.WriteLine(number1);
            String nibble1 = number1.Substring(0, 4);
            String nibble2 = number1.Substring(4, 4);
            String newNumber = nibble2 + nibble1;
            Console.WriteLine("Binary number after swapping -- "+newNumber);
            Console.WriteLine("New Number after swapping nibbles -- "+Convert.ToInt32(newNumber,2));
        }
    }
}
