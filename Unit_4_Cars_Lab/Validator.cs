using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Cars_Lab
{
    internal class Validator
    {
        public static int GetNumber(string msg, int lower, int upper)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num >= lower && num <= upper)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Out of range");
                    return GetNumber(msg, lower, upper);
                }
            }
            catch (FormatException e )
            {
                Console.WriteLine("Invalid Input.");
                return GetNumber(msg, lower, upper);
            }
        }




    }
}
