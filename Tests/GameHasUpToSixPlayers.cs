using NUnit.Framework;
using System;

namespace UglyTrivia
{
    [TestFixture]
    class GameHasUpToSixPlayers
    {
        Game game;

        [SetUp]
        public void CreateNewGame()
        {
            game = new Game();
        }

        [Test]
        public void NewGameHasZeroPlayers()
        {
            Assert.That(game.howManyPlayers(), Is.EqualTo(0));
        }

        [Test]
        public void CanAddOnePlayer()
        {
            game.add("player");
            Assert.That(game.howManyPlayers(), Is.EqualTo(1));
        }

        [Test]
        public void CanAddMulitplePlayers()
        {
            game.add("player");
            game.add("player");

            Assert.That(game.howManyPlayers(), Is.EqualTo(2));
        }

        [Test]
        public void MaximumOfSixPlayers()
        {
            var players = new int[5];

            foreach (var p in players)
            {
                game.add(p.ToString());
            }

            Assert.Throws<IndexOutOfRangeException>(delegate { game.add("too many players"); });
        }
    }
}
