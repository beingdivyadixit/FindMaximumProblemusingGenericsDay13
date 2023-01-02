using System;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter - \n 1: To find max for integer\n 2: To find max for floats");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //UC1
                  FindMax.MaxNumber();
                    break;
                case 2:
                    //UC2
                    FindMax.MaxNumberFloat();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
             }
        }
    }
}
