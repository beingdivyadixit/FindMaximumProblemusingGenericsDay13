using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class FindMax<T> where T: IComparable
    {  
        public T first, second, third;
        public T[] value;
        public FindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        //UC4
        public FindMax(T[] value)
        {
            this.value = value;
        }
        // **UC1**
        /*public static void MaxNumber()          //Creating method to find maximum with CompareTo method
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
        }*/

        // **UC2**
        /* public static void MaxNumberFloat()         //Creating method to find maximum number using CompareTo method for float
         {
             Console.WriteLine("Enter First float Number");
             float a = Convert.ToSingle(Console.ReadLine());
             Console.WriteLine("Enter Second float Number");
             float b = Convert.ToSingle(Console.ReadLine());
             Console.WriteLine("Enter Third float Number");
             float c = Convert.ToSingle(Console.ReadLine());
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
         }*/

        // **UC3**
       /*  public static void MaxNumberString()         //Creating method to find maximum for string using ComapreTo method for string
        {
            Console.WriteLine("Enter first string ");
            string a =Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second string ");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter third string ");
            string c = Convert.ToString(Console.ReadLine());
            if ((a.CompareTo(b) >= 0) && (a.CompareTo(c) >= 0))
            {
                Console.WriteLine("The maximum  is:" + a);
            }
            else if ((b.CompareTo(a) >= 0) && (b.CompareTo(c) >= 0))
            {
                Console.WriteLine("The maximum  is: " + b);
            }
            else
            {
                Console.WriteLine("The maximum  is : " + c);
            }
        }*/

        // Refactor -1
        public static T GenericMaxNumber(T first, T second, T third)          //Creating method to find maximum  by using Generic method
        {
           
            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else
            {
                return third;
            }
        }
        // Refactor -2
        public void TestMaximum()
        {
            T res = GenericMaxNumber(first, second, third);
            Console.WriteLine("Max:"+res);
        }
       
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
    }
}
