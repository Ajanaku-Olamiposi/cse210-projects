using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);

        int guess = -1;
        int guessCount = 0;
        string message;
        string ans = "yes";

        while (ans.ToLower() == "yes")
        {
            guessCount = 0;
            while (guess != num)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount ++;
                if (guess < num)
                {
                    message = "Higher";
                }
                else if (guess > num)
                {
                    message = "Lower";
                }
                else
                {
                    message = $"You guessed it!. It took you {guessCount}tries. ";
                }
                Console.WriteLine(message);
            }

            Console.Write("Do you want to play again? (yes/no) ");
            ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                num = randomGenerator.Next(1, 100);
                guess = -1;
            }
        }
    }
}