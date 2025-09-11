using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("Remember that you need at least 70 to pass.");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);


        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed. ");
        }
        else
        {
            Console.WriteLine("We sorry, yo didn't pass. Keep trying, that is the key and you can do it!");
        }

        string letter = ""
;
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your qualification is {letter}. ");


        /*-----If example: -----"
        if (x > y)
        {
            Console.WriteLine("Greater");

        }
        ----- End of the example -----*/


    }
}