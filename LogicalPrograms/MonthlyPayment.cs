using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public static void CalculateMonthlyPayment()
        {
            Console.WriteLine("Enter prinicpal loan amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter interest rate");
            double R = Convert.ToInt32(Console.ReadLine());
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly Payments is: " + payment);
        }
    }
}
