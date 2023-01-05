using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); //Dsiplays a welcome message.
        string uName = GetUserName(); //Calls a function to prompt for user name.
        int number = GetUserNumber(); //Prompts for a number.
        int square = SquareNumber(number); //Squares the number received.
        DisplayInfo(uName, square); //DIsplays the info received and processed.    

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the machine!");
        }

    static string GetUserName()
    {
        //Prompts for and returns user name.
        Console.Write("What is your last name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int GetUserNumber()
    {   
        //Prompts for and returns a number
        Console.Write("Tel me your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        //Squares a number received.
        int squared = number*number;
        return squared;
    }

    static void DisplayInfo(string uName, int square)
    {
        //Displays processed info.
        Console.WriteLine($"Brother {uName}, the square of your number is {square}.");
    }
    
    
}