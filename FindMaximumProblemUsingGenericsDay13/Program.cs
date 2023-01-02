using System;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter - \n 1: To find max for integer\n 2: To find max for floats\n 3: To find max for string");
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
                case 3:
                    //UC3
                    FindMax.MaxNumberString();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
             }
        }
    }
}
