using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);        

        int yourGuess = -1;

        //Console.WriteLine($"What is the magic number? {magicNumber}");
        //string yourGuess = Console.ReadLine();
        //int yourGuessNumber = int.Parse(yourGuess);

        while (yourGuess != number)
        {
        Console.Write($"What is your guess? ");
        yourGuess = int.Parse(Console.ReadLine());

            if (number < yourGuess)
            {
                Console.WriteLine("Lower. ");
            }
            else if (number > yourGuess)
            {
                Console.WriteLine("Higher. ");
            } 
            else
            {
                Console.WriteLine("You guessed it! ");
            }
        }
    }
}