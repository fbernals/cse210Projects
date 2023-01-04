using System;

class Program
{
    static void Main(string[] args)
    {
        //Declares needed variables
        int guess = 0;
        string tryAgain = null;
        int counter = 0;

        do //Starts routine and repeats until user enters anything other than 'y'
        {
            Random rNumber = new Random();
            int number = rNumber.Next(1,10); //Generates a number between 1 and 10 for the user to guess it
            counter = 0; //Resets counter to 0
            while (guess != number)
            {
                //Asks user for a guess and assigns its value to variable 'guess'
                Console.WriteLine("Can you guess my number?");
                Console.Write("Enter a guess between 1 and 10: ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                //Compares and asks user to raise or lower entered number until user guesses it
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    counter++;
                    
                }else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    counter++;
                }else if (guess == number)
                {   
                    //Notifies the user of a correct guess and asks if user wants to try again.
                    Console.WriteLine("You guessed it");
                    counter++;
                    Console.WriteLine($"It took you {counter} tries to guess it.");
                    Console.Write("Try again?(y/n): ");
                    tryAgain = Console.ReadLine();
                }
            }
            
        }while (tryAgain == "y");
    }
}