using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write. ");
        Console.WriteLine("2. Display. ");
        Console.WriteLine("3. Load. ");
        Console.WriteLine("4. Save. ");
        Console.WriteLine("5. Quit. ");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
        string answer = Console.ReadLine();
        int answerNumber = int.Parse(answer);

        if (answerNumber == 1 )
        {
            Console.WriteLine("Good.");
        }
    }   
}