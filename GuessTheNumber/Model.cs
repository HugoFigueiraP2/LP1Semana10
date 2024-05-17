using System;

namespace GuessTheNumber
{
    public class Model
    {
        private int _targetNumber;
        private int _attempt;
        public void Generator ()
        {
            Random random = new Random();

            // Generate a number between 1 and 100
            _targetNumber = random.Next(1, 101);
            Console.WriteLine("Corret number: "+targetNumber);
        

        }

        public int IncrementAttempt()
        {
            _attempt++;
            return _attempts;

        }

        public bool StateWin(int guess)
        {
            return guess == targetNumber;
        }

        public bool HitGuess(int guess)
        {
            if (guess > attempt)
            {
                return true;
            }
            else
                return false;
        }
       

        

    }

}