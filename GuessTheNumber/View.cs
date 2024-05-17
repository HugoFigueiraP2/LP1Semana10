using System;

namespace GuessTheNumber
{
    public class View : IView
    {
        public string WelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public string TakeGuess()
        {
            Console.Write("Take a guess: ");

        }

        public string Correct()
        {
            Console.WriteLine(
                        "Congratulations! You guessed the number correctly!");
                    Console.WriteLine("Number of attempts: " + attempts);
                    
        }

        public string TooLow()
        {
             Console.WriteLine("Too low! Try again.");
        }

        public string ToHigh()
        {
            {
                Console.WriteLine("Too high! Try again.");
            }
        }

        public string EndMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }

        
        

    }
}