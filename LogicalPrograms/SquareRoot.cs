using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class SquareRoot
    {
        public static void FindSquareRoot()
        {
            Console.WriteLine("Enter non-negative number");
            double c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            if (c > 0)
            {
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = ((c / t) + t) / 2;
                }
                Console.WriteLine(t);
            }
            else
            {
                Console.WriteLine("Enter non-negative number only");
            }
        }
    }
}
