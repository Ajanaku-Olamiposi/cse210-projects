using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(squaredNumber, userName);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        int Square = num * num;
        return Square;
    }
    static void DisplayResult(int square, string name)
    {
         Console.WriteLine($"{name}, the square of your number is {square}");
    }
}