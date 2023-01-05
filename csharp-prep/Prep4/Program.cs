using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        int total = 0;
        double average = 0;
        int maximum = 0;
        int minimum = 0;
        int aMinimum = 100;

        do
        {

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

        Console.WriteLine(numbers[i]);
        total = numbers.Sum();
        average = numbers.Average();
        maximum = numbers.Max();
        if (numbers[i] > 0)
        {
            minimum = numbers[i];
            if (minimum < aMinimum)
            {
                aMinimum = minimum;
            }

        }

        }

        numbers.Sort();

        Console.WriteLine($"The sum of all list items is {total}");
        Console.WriteLine($"The average of all items is {average}");
        Console.WriteLine($"The maximum value is {maximum}");
        Console.WriteLine($"The minimum positive value is {aMinimum}");
        Console.WriteLine("This is the sorted list:");
        foreach(int item in numbers)
        {
            Console.WriteLine(item);
        }

    }
    
    
}