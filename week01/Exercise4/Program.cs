using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int addedNumbers = -1;

        Console.WriteLine("Please write some integer numbers. When you type zero, the program will stop. ");
        
        //Loop from here.

        while (addedNumbers != 0)
        {
        Console.Write("Enter number: ");
        string userNumber = Console.ReadLine();
        addedNumbers = int.Parse(userNumber);

        if (addedNumbers != 0)
            {
                numbers.Add(addedNumbers);
            }
        }
        //numbers.Add(addedNumbers); "Close, but not yet." 

        // Console.WriteLine(numbers); Shows: System.Collections.Generic.List`1[System.Int32]

        //Console.WriteLine(numbers.Count);
        // Shows: The number of numbers that I add.

        int sum = 0;
        foreach (int number in numbers)
            {
                sum += number;
            }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers [0];

        foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
        
        Console.WriteLine($"The max is: {maxNumber} ");
    }
}