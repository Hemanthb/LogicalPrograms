using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TempConversionUc9
    {
        double fahTemp,celTemp;
        public void ConvertTemperatureUnit(double temp,char unit)
        {
            if (char.ToLower(unit) == 'c')
            {
                fahTemp = ((temp * 9) / 5) + 32;
                Console.WriteLine("{0} celsius is converted to {1} fahrenheit",temp,fahTemp);

            }
            else if (char.ToLower(unit) == 'f')
            {
                celTemp = ((temp - 32) * 5) / 9;
                Console.WriteLine("{0} fahrenheit is converted to {1} celsius", temp, celTemp);
            }
        }
    }
}
