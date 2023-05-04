using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        
        public static void GetChange()
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int count = 0;
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered amount is: " + amount);
            for (int i=0; i<notes.Length; i++)
            {
                if (amount / notes[i] >= 1 && amount != 0)
                {
                    int change = amount / notes[i];
                    count += change;
                    Console.WriteLine(notes[i] + " Notes ---> " + change);
                    amount -= notes[i] * change;
                }
            }
            Console.WriteLine("Total number of Notes: " + count);
        }
    }
}
