using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public static void DistinctCoupon()
        {
            Console.WriteLine("Enter size of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random();
            arr[0] = random.Next(0, n);
            Console.Write("Coupon Numbers are: ");
            for (int i=1; i<n; i++)
            {
                int coupon = random.Next(0, n);
                for (int j=1; j<i; j++)
                {
                    if (arr[j] != coupon)
                    {
                        arr[i] = coupon;
                    }
                }
                Console.Write(" " + arr[i]);
            }
        }
    }
}
