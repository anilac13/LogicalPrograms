using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void FindPrimeNumber()
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool Is_Prime = true;
            int i;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Is_Prime = false;
                    break;
                }
                else
                {
                    Is_Prime = true;
                }
            }
            if (Is_Prime == true)
                Console.WriteLine("{0} is Prime Number", num);
            else
                Console.WriteLine("{0} is not Prime Number", num);
        }
    }
}
