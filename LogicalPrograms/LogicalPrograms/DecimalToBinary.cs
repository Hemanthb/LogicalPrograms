using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DecimalToBinary
    {
        private static String binary = "";   
        public static void ConvertDecimaltoBinary(Decimal number)
        {
            while (number > 1)
            {
                int rem = (int)number % 2;
                binary += Convert.ToString(rem);
                number = number / 2;
            }
            Console.WriteLine("Decimal Number converted to binary is -"+binary);
        }
    }
}
