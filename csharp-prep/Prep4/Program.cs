using System;

class Program
{
    static void Main(string[] args)
    {
        //Declares variables and initialize them.
        List<int> numbers = new List<int>();
        int number = 0;
        int total = 0;
        double average = 0;
        int maximum = 0;
        int minimum = 0;
        int aMinimum = 100;

        do
        {
            //While value is not 0 asks user for input and ads them to the list
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);

            }else if (number == 0)
            {
                break;
            }

        }while(number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {

        Console.WriteLine(numbers[i]); //Prints each number from the list
        total = numbers.Sum(); //Sums up all the numbers
        average = numbers.Average(); //Gets the average of all values
        maximum = numbers.Max(); //Gets the maximum value from the list
        if (numbers[i] > 0)
        {
            //Gets the minimum positive value from the list
            minimum = numbers[i];
            if (minimum < aMinimum)
            {
                aMinimum = minimum;
            }

        }

        }
        //Sorts and prints list´s values and requested operations results.
        numbers.Sort();

        Console.WriteLine($"The sum of all list items is {total}");
        Console.WriteLine($"The average of all items is {average}");
        Console.WriteLine($"The maximum value is {maximum}");
        Console.WriteLine($"The minimum positive value is {aMinimum}");
        Console.WriteLine("This is the sorted list:");
        foreach(int item in numbers)
        {
            Console.WriteLine(item); //Prints sorted list.
        }

    }
    
    
}