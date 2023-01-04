using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade = null;
        string plusMinus = null;

        if (grade >= 0 && grade <=100)
        {
            if (grade<60)
            {
                letterGrade = "F";
            }else if (grade>=90)
            {
                letterGrade = "A";
            }else if (grade>=80)
            {
                letterGrade = "B";
            }else if (grade>=70)
            {
                letterGrade = "C";
            }else if (grade>=60)
            {
                letterGrade = "D";
            }
        }else{
            Console.WriteLine("Not a valid grade. Enter a number between 0 and 100.");
            return;
        }
        if (grade > 60 && grade < 93)
        {
            if ((grade%10)>=3)
            {
                plusMinus = "+";
            }else{plusMinus = "-";}
        }

        Console.Write($"Your letter grade is {letterGrade}{plusMinus}");
        if (grade < 70)
        {
            Console.WriteLine("\nSorry, you failed this course. Keep trying.");
        }else
        {
            Console.WriteLine("\nCongratulations! You passed!");
        }
    }
}