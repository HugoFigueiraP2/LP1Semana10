using System;

namespace GuessTheNumber
{
    public interface IView
    {
        void WelcomeMessage();
        

        void TakeGuess();
        

        void Correct();
        

        void TooLow();
        

        void ToHigh();
        

        void EndMessage();
        

    }
}