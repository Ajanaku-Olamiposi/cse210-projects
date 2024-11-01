using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        DateTime date = DateTime.Now;

        Exercise running = new Running(120, date, 60);
        exercises.Add(running);
        Exercise swimming = new Swimming(1000, date, 10);
        exercises.Add(swimming);
        Exercise cycling = new Cycling(10, date, 40);
        exercises.Add(cycling);

        foreach(var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}