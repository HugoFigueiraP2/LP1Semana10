using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public interface IView
    {
        int MainMenu();

        void EndMassage();

        void InvalidOption();

        void AfterMenu();


        Player InsertPlayer();

        void ListPlayers();

        void ListPlayersWithScoreGreaterThan();


        int AskForMinimumScore();


        PlayerOrder AskForPlayerOrder();


    }
}