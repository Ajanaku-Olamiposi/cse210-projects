using System;
// Exceeding Requirements..............I added the total time the user spent on the app
class Program
{
    static void Main(string[] args)
{
    DateTime startTime = DateTime.Now;
    int choice = -1;
    while (choice != 4)
       {
        Console.WriteLine("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.");
            activity.DisplayStartingMessage();

            activity.Run();

            activity.DisplayEndingMessage();
        }
        else if (choice == 2)
        {
            ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognise the power you have and how you can use it in other aspects of your life.");
            activity.DisplayStartingMessage();

            Console.Write($"Consider the following prompt:\n---{activity.GetRandomPrompt()}---\nWhen you have something in mind, press enter to continue. ");
            Console.ReadLine();
            Console.Write($"Now ponder on each of the following questions as they relate to this experience.\nYou may begin in: ");
            Thread.Sleep(1000);
            Console.WriteLine(activity.ShowCountDown(5));
            Console.Clear();

            activity.DisplayQuestions();

            activity.DisplayEndingMessage();
        }
        else if (choice == 3)
        {
            ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            activity.DisplayStartingMessage();

            Console.WriteLine("List as many responses as you can to the following prompt:");
            activity.GetRandomPrompt();
            Console.Write("You may begin in: ");
            Thread.Sleep(1000);
            Console.WriteLine(activity.ShowCountDown(5));

            activity.Run();

            activity.DisplayEndingMessage();
        }
        else
        {
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpent = endTime - startTime;
            Console.WriteLine($"You spent a total of {timeSpent.Seconds} Seconds on the Mindfulness app today great work!!");
        }
       }
}
}