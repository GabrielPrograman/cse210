using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicnumber = randomgenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicnumber)
       {

        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicnumber > guess)
        {
            Console.WriteLine("Too low!");
        }
        else if (magicnumber < guess)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the number!");
       
         }
       }
    }
}