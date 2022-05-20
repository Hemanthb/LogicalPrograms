using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class MonthlyPaymentUc10
    {
        public static void CalculateMonthlyPayment(int principal,int years,int rate)
        {
            int n = years*12;
            decimal r = (decimal)rate / 1200;
            //Console.WriteLine(r);
            double payment = (principal * Convert.ToDouble(r)) / (1 - Math.Pow(1 + Convert.ToDouble(r), -n));
            Console.WriteLine("Payment to be made monthly is Rs. " + payment);
        }
    }
}
