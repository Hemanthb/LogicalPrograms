using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumberUc5
    {
        int CouponCount = 0,UniqueCouponCount=0,i=0;
        Random Random = new Random();
        List<int> couponCodes = new List<int>();
        public void GenerateCoupon(int no)
        {
            while(UniqueCouponCount < no)
            {
                int couponNo = Random.Next();
                CouponCount++;
                if (!couponCodes.Contains(couponNo))
                {
                    //couponCodes[i] = couponNo;
                    couponCodes.Add(couponNo);
                    UniqueCouponCount++;
                }

            }
            foreach (int couponCode in couponCodes)
            {
                Console.WriteLine(couponCode);
            }
            Console.WriteLine("Number of times taken to generate {0} Unique coupon code is {1}",no, CouponCount);
            
        }
    }
}
