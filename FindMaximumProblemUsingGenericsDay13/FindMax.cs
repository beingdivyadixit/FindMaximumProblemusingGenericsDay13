using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class FindMax
    {
        public static void MaxNumber()          //Creating method to find maximum with CompareTo method
        {
            Console.WriteLine("Enter First Integer Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Integer Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Integer Number");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is:" + a);
            }
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
            {
                Console.WriteLine("The maximum number is: " + b);
            }
            else
            {
                Console.WriteLine("The maximum number is : " + c);
            }
        }
    }
}
