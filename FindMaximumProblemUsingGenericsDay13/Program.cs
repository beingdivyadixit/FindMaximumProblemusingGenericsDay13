using System;

namespace FindMaximumProblemUsingGenericsDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter - \n 1: To find max for integer\n 2: To find max for floats\n 3: To find max for string\n 4: To find max using Generic Method\n 5: To find max using Generic class");
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
                    {  //Refactor-1
                        
                        //INTEGER
                        Console.WriteLine("Enter First Integer Number");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Integer Number");
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Third Integer Number");
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Max Value:" + FindMax<int>.GenericMaxNumber(firstInt, secondInt, thirdInt));
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
                    }
                    break;
                case 5:
                    {  //RefCTOR-2

                        //INTEGER
                        Console.WriteLine("Enter First Integer Number");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Integer Number");
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Third Integer Number");
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        FindMax<int> obj = new FindMax<int>(firstInt,secondInt,thirdInt);
                        obj.TestMaximum();
                        //FLOATS
                        Console.WriteLine("Enter First float Number");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Second float Number");
                        float secondFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Third float Number");
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        FindMax<float> obj2 = new FindMax<float>(firstFloat, secondFloat, thirdFloat);
                        obj2.TestMaximum();
                        //STRING
                        Console.WriteLine("Enter First string");
                        string firstString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter string");
                        string secondString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Third string");
                        string thirdString = Convert.ToString(Console.ReadLine());
                        FindMax<string> obj3 = new FindMax<string>(firstString, secondString, thirdString);
                        obj3.TestMaximum();
                    }
                    break;
                case 6:
                    {//UC-4

                        //INTEGER
                        Console.WriteLine("Enter the count of integer number");
                        int count= Convert.ToInt32(Console.ReadLine());
                        int[] numbersInt =new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            numbersInt[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        FindMax<int> obj = new FindMax<int>(numbersInt);
                        obj.MaxMethod();
                        //FLOATS
                        Console.WriteLine("Enter the count of float number");
                        int count1 = Convert.ToInt32(Console.ReadLine());
                        float[] numbersFloat = new float[count1];
                        for (int i = 0; i < count; i++)
                        {
                            numbersFloat[i] = Convert.ToSingle(Console.ReadLine());
                        }
                        FindMax<float> obj2 = new FindMax<float>(numbersFloat);
                        obj2.MaxMethod();
                        //STRING
                        Console.WriteLine("Enter the count of string");
                        int count2 = Convert.ToInt32(Console.ReadLine());
                        string[] numbersString = new string[count2];
                        for (int i = 0; i < count; i++)
                        {
                            numbersString[i] = Convert.ToString(Console.ReadLine());
                        }
                        FindMax<string> obj3 = new FindMax<string>(numbersString);
                        obj3.MaxMethod();

                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
             }
        }
    }
}
