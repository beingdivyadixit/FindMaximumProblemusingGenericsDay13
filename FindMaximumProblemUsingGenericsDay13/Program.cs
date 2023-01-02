using System;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter - \n 1: To find max for integer\n 2: To find max for floats\n 3: To find max for string\n 4: To find max using Generics");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //UC1
                  // FindMax.MaxNumber();
                    break;
                case 2:
                    //UC2
                   // FindMax.MaxNumberFloat();
                    break;
                case 3:
                    //UC3
                   // FindMax.MaxNumberString();
                    break;
                case 4:
                    //UC4
                    //INTEGER
                    Console.WriteLine("Enter First Integer Number");
                    int firstInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Integer Number");
                    int secondInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Third Integer Number");
                    int thirdInt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max Value:"+FindMax<int>.GenericMaxNumber(firstInt,secondInt,thirdInt));
                    //FLOATS
                    Console.WriteLine("Enter First float Number");
                    float firstFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Second float Number");
                    float secondFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Third float Number");
                    float thirdFloat = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Max Value:" + FindMax<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat));
                    // STRINGS
                    Console.WriteLine("Enter First string");
                    string firstString = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter string");
                    string secondString = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Third string");
                    string thirdString = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Max Value:" + FindMax<string>.GenericMaxNumber(firstString, secondString, thirdString));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
             }
        }
    }
}
