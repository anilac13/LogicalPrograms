using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public static void ConvertTemperature()
        {
            Console.WriteLine("Enter temperature");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose option to perform \n1.Celcius to Fahrenheit \n2.Fahrenheit to Celcius");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    int F = (temp * 9 / 5) + 32;
                    Console.WriteLine(F + " F");
                    break;
                case 2:
                    int C = (temp - 32) * 5 / 9;
                    Console.WriteLine(C + " C");
                    break;
            }
        }
    }
}
