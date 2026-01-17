using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int magicNumber = 6;
        Console.WriteLine($"What is the magic number? {magicNumber}");
        Console.Write($"What is your guess? ");
        string yourGuess = Console.ReadLine();
        int yourGuessNumber = int.Parse(yourGuess);

        if (yourGuessNumber < magicNumber)
        {
            Console.WriteLine("Lower. ");
        }
        else if (yourGuessNumber == magicNumber)
        {
            Console.WriteLine("You guessed it! ");
        } 
        else
        {
            Console.WriteLine("Higher. ");
        }

        
    }
}