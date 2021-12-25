using System;
using System.Threading;

namespace A22_Ex02
{
    public class Program
    {
        public static void Main()
        {
            bool isPlay = true;
            while(isPlay)
            {
                Console.Clear();
                Game currentGame = new Game(UserInterface.GetNumberOfGuesses());
                currentGame.PlayGame(out isPlay);
                if(!isPlay)
                {
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    isPlay = UserInterface.IsNewGame();
                }
            }
        }
    }
}