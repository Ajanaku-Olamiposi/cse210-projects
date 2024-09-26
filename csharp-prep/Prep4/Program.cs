using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = -1;
        List<int> numbers = new List<int>();
        while(num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if(num != 0)
            {
                numbers.Add(num);
            }
        }
        
        int length = numbers.Count;
        int sum = 0;
        int max = numbers[0];
        int smallestPositive = numbers.Where(n => n > 0).Min();

        numbers.Sort();
        foreach(int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            // Console.WriteLine(number);
            // Console.WriteLine(sum);. Having the print statement in here does a progressive sum as you iterate along the list showing each sum at every point. Could be useful sometimes later
        }
        float avg = ((float) sum)/length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The max is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}