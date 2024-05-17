using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private Model GameData;
        private IView _view;

        public Controller (Model model_1)
        {
            GameData = model_1;

        }

        public void GameLoop(IView view)
        {
            _view = view;
            int guess = -1;


            _view.WelcomeMessage();
            GameData.Generator();

            while (!guessedCorrectly)
            {
                
                
                guess = GameData.TakeGuess();
                int attempt = GameData.IncrementAttempt();
                if (GameData.StateWin(guess))
                {
                    _view.Correct();
                    break;

                }
                if (GameData.HitGuess(guess) == true)
                {
                    _view.ToHigh();
                }
                else
                {
                    _view.TooLow();
                }
                

    
            }
            _view.EndMessage();
        }

    }

}