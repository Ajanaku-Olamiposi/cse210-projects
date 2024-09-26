using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int score = int.Parse(gradePercentage);

        string grade;
        if(score >= 90)
        {
            grade = "A";
        }
        else if(score >= 80)
        {
            grade = "B";
        }
        else if(score >= 70)
        {
            grade = "C";
        }
        else if(score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        string message;
        if(score >= 70)
        {
            message = "Congratulations, you passed the course.";
        }
        else
        {
            message = "You failed the course but not in life, please be encouraged to retake the course and study harder.";
        }
        
        string sign = "";
        if(score >= 60 && score <= 92)
        {
            if((score % 10) < 3)
            {
                sign = "-";
            } 
            else if((score % 10) >= 7)
            {
                sign = "+";
            } 
        }
        Console.WriteLine($"Your grade is {grade}{sign}. {message}");
    }
}