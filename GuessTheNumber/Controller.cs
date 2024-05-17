using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private Model GameData;

        public Controller (Model model_1)
        {

        }

        public int GameLoop()
        {
             while (!guessedCorrectly)
            {
                //Console.Write("Take a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == targetNumber)
                {
                    //Console.WriteLine(
                    //    "Congratulations! You guessed the number correctly!");
                    //Console.WriteLine("Number of attempts: " + attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    //Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    //Console.WriteLine("Too high! Try again.");
                }
            }
        }
    
    }

}