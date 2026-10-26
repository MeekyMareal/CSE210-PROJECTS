using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string inputOne = Console.ReadLine();
        // int number = int.Parse(inputOne);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        // Console.Write("What is the magic number? ");
        // string inputTwo = Console.ReadLine();
        // int guess = int.Parse(inputTwo);
        int guess = -1;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (number > guess)
            {
                Console.Write("Wrong guess, Higher.. What is the magic number? ");
            }
            else if (number < guess)
            {
                Console.Write("Wrong guess, Lower.. What is the magic number? ");
            }
            else
            {
                Console.WriteLine("Congratulations, you have guessed the right number");
            }
        }
    }
}