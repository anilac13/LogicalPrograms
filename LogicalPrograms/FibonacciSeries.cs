using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void PrintFibonacciSeries()
        {
            Console.WriteLine("Enter number to print Fibonacci series");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.Write("Fibonacci series is: " + firstNum + " " + secondNum);
            for (int i = 2; i < num; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write(" " + thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }
    }
}
