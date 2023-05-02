using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void ReverseGivenNumber()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse of number is {0}", rev);
        }
    }
}
