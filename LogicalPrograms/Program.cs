using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Print Fibonacci series \n2.Perfect number \n3.Prime number \n4.Reverse a number \n5.Coupon Numbers \n6.Stop Watch \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries.PrintFibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber.FindPrimeNumber();
                        break;
                    case 4:
                        ReverseNumber.ReverseGivenNumber();
                        break;
                    case 5:
                        CouponNumbers.DistinctCoupon();
                        break;
                    case 6:
                        StopWatch.CalculateTime();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}