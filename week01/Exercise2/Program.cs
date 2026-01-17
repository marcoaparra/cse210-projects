using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        double percentage = double.Parse(number);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        /* 
        This is my first idea. I knew that was wrong, it was not simple.

            if (percentage >= 90)
            {
                Console.WriteLine($"Your grade is {letter}.");
                if (percentage >= 90)
                {
                    Console.WriteLine("Congratulations! You passed the course!");
                }
            }
            else if (percentage >= 80)
            {
                Console.WriteLine($"Your grade is {letter}.");
                if (percentage >= 80)
                {
                    Console.WriteLine("Congratulations! You passed the course!");
                }
            }
            else if (percentage >= 70)
            {
                Console.WriteLine($"Your grade is {letter}.");
                if (percentage >= 70)
                {
                    Console.WriteLine("Congratulations! You passed the course!");
                }
            }
            else if (percentage >= 60)
            {
                Console.WriteLine($"Your grade is {letter}.");
                if (percentage <= 69)
                {
                    Console.WriteLine("I'm sorry, you did not pass the course.");
                }
            }
            else if (percentage < 60)
            {
                Console.WriteLine($"Your grade is {letter}.");
                 if (percentage <= 69)
                {
                    Console.WriteLine("I'm sorry, you did not pass the course. Keep trying! You can do it!");
                }
            }       
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric grade percentage.");
            }
        */

        Console.WriteLine($"Your grade is {letter}.");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("I'm sorry, you did not pass the course. Keep trying! You can do it!");
        }
}
}
