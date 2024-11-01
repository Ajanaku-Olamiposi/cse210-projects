using System;
// Exceeding requirements------- I added functionality that enables the user to clear the goals in the file and start afresh----------------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int choice = -1;
        while (choice != 7)
        {
            goalManager.Start();
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goalManager.CreateGoal();
            }
            if (choice == 2)
            {
                Console.WriteLine("The goals are:");
                goalManager.ListGoalDetails();       
            }
            if (choice == 3)
            {
                goalManager.SaveGoals(); 
                Console.WriteLine("Updating file....");
                Console.WriteLine("File updated");
            }
            if (choice == 4)
            {
                goalManager.LoadGoals(); 
                Console.WriteLine("File loading....");
                Console.WriteLine("File loaded");
            }
            if (choice == 5)
            {
                goalManager.RecordEvent(); 
            }
            if (choice == 6)
            {
                goalManager.ClearGoals(); 
                Console.WriteLine("File Successfully cleared");
            }
        }
    }
}