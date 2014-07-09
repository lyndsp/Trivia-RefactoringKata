using System;

namespace UglyTrivia
{
    public class GameRunnerGoldMaster
    {
        private bool notAWinner;

        public void Run(int seed)
        {
            Game aGame = new Game();

            aGame.add("Chet");
            aGame.add("Pat");
            aGame.add("Sue");

            Random rand = new Random(seed);

            do
            {
                aGame.roll(rand.Next(5) + 1);

                if (rand.Next(9) == 7)
                {
                    notAWinner = aGame.wrongAnswer();
                }
                else
                {
                    notAWinner = aGame.wasCorrectlyAnswered();
                }
            } while (notAWinner);
        }
    }
}