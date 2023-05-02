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
                Console.WriteLine("\nChoose option to perform \n1.Print Fibonacci series \n2.Perfect number \n3.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}