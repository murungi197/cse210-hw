using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
     
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Core calculations
        int sum = 0;
        int max = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;

            if (num > max)
            {
                max = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch: smallest positive number
        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch: sort and display list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}