using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            //Console.WriteLine("Enter any number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //for (int i = 1; i < num; i++)
            //{
            //    if (num % i  == 0)
            //    {
            //        result += i;
            //    }
            //}
            //if (result == num)
            //{
            //    Console.WriteLine("{0} is a Perfect number", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a Perfect number", num);
            //}

            Console.WriteLine("Print Perfect numbers in given range");
            Console.WriteLine("Enter starting range");
            int mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending range");
            int mx = Convert.ToInt32(Console.ReadLine());
            for (int n = mn; n <= mx; n++)
            {
                int sum = 0;
                int i = 1;
                while (i < n)
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
        }
    }
}
