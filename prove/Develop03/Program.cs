using System;
using System.ComponentModel;
// Exceeding requirements;  I added functionality that enables the user to input whatever chapter and verse of the bible they want to memorise

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter the book of the Bible:");
        string book = Console.ReadLine().ToLower();

        Console.WriteLine("Enter the chapter number:");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the verse number:");
        int verse = int.Parse(Console.ReadLine());

        string version = "en-kjv";
        string url = $"https://cdn.jsdelivr.net/gh/wldeh/bible-api/bibles/{version}/books/{book}/chapters/{chapter}/verses/{verse}.json";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                string verseText = jsonResponse;
                Reference reference = new Reference(book.ToUpper(), chapter, verse);
                Scripture scripture = new Scripture(reference, verseText);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                    string answer = Console.ReadLine();
                    if (answer == "quit" || scripture.IsCompletelyHidden()) 
                    {
                        break;
                    }
                    scripture.HideRandomWords(3);
                }
            }
            else
            {
                Console.WriteLine("Error fetching the verse.");
            }
        }
    }
}