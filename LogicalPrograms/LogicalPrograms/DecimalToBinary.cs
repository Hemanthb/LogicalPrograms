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
            char[] binaryDigit = binary.ToCharArray();
            Array.Reverse(binaryDigit);
            String binary_digits = new string(binaryDigit);
            binary_digits = binary_digits.PadLeft(8, '0');
            Console.WriteLine("Decimal Number converted to binary is - "+binary_digits);
        }
    }
}
