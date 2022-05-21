using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class DayOfWeekUc8
    {
        static int m1, x, y1, Day;
       
        public static void FindDayOfWeek(int month,int day,int year)
        {
            y1 = year - (14 - month)/12;
            x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            m1 = month + 12 * ((14 - month) / 12) - 2;
            Day = (day + x + (31 * (m1 / 12))) % 7;
            switch (Day)
            {
                case 0:
                    Console.WriteLine("{0} -- Sunday",Day);
                    break;
                case 1:
                    Console.WriteLine("{0} -- Monday", Day);
                    break;
                case 2:
                    Console.WriteLine("{0} -- Tuesday", Day);
                    break;
                case 3:
                    Console.WriteLine("{0} -- Wednesday", Day);
                    break;
                case 4:
                    Console.WriteLine("{0} -- Thursday", Day);
                    break;
                case 5:
                    Console.WriteLine("{0} -- Friday", Day);
                    break;
                case 6:
                    Console.WriteLine("{0} -- Saturday", Day);
                    break;
                default:
                    break;
            }

        }
    }
}
