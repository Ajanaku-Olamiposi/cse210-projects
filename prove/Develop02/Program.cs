using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int choice = -1;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                entry._time = theCurrentTime.ToString("HH:mm");

                PromptGenerator generator = new PromptGenerator();
                entry._promptText = generator.GetRandomPrompt();
                Console.Write($"{entry._promptText}\n>");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Loading file.....");
                Console.WriteLine("Loaded file. Select option 2 to display the content.");

            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Saving to file.....");
                Console.WriteLine("Saved to file");
            }
        }

    }
}