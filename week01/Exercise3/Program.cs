using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)

        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        /* Console.Write("What is the magic number? ");
        string magic_number = Console.ReadLine();
        int int_magic_number = int.Parse(magic_number);

        Console.Write("What is your guess? ");
        string guess_number = Console.ReadLine();
        int int_guess_number = int.Parse(guess_number);

        if (int_guess_number == int_magic_number)
        {
            Console.WriteLine("You guessed it! ");
        }   
        else if (int_guess_number > int_magic_number)
        {
            Console.WriteLine("Lower. ");
        }
        else if (int_guess_number < int_magic_number)
        {
            Console.WriteLine("Higher. ");
        }
        
        while (int_guess_number != int_magic_number)
        {
            Console.Write("What is your guess? ");
            magic_number = Console.ReadLine();
        }
        
    */
            /*
                WHILE LOOP:
                string response = "yes";
                while (response == "yes")
                {
                Console.Write("Do you want to continue? ");
                response = Console.ReaLine();
                }
                -----------------------------------------
                DO-WHILE LOOP:
                string response;

                do
                {
                    Console.Write("Do you want to continue? ");
                    response = Console.ReadLine();
                } while (response == "yes");
                -----------------------------------------
                FOR LOOP:
                The following code shows the syntax of a for loop that counts from 0 to 9.

                for (int i = 0; i < 10; i++)
                {
                Console.WriteLine(i);
                }

                In that code, you will see the use of the ++ operator which increments the value in the variable by one.
                The code above is the most common way to see one of these loops, but you could put other values or statements in these spots, such as counting from 2 to 20 by two's:
                for (int i = 2; i <= 20; i = i + 2)
                {
                Console.WriteLine(i);
                }
                -----------------------------------------
                FOREACH LOOP:
                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }
                The foreach loop will be used extensively in the next preparation material that discusses lists.
                -------------------------------------------

                RANDOM NUMBERS:
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 11);
                --------------------------------------------
             */
    }
}