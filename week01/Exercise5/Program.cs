using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

        /*

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program! ");
        }

        static string PromptUserName(string userName)
        {
            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! ");
        }

        static int PromptUserNumber (int favoriteNumber)
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
        }

        static void DisplayResult (string PromptUserName);
        {
            Console.WriteLine($"{userName}, the square of your favorite color is {}")
        }

        */