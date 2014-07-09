using NUnit.Framework;
using System;

namespace UglyTrivia
{
    [TestFixture]
    class FirstTests
    {
        [Test]
        public void NewGameHasZeroPlayers()
        {
            var game = new Game();

            Assert.That(game.howManyPlayers(), Is.EqualTo(0));
        }

        [Test]
        public void CanAddOnePlayer()
        {
            var game = new Game();

            game.add("player");

            Assert.That(game.howManyPlayers(), Is.EqualTo(1));
        }

        [Test]
        public void CanAddMulitplePlayers()
        {
            var game = new Game();

            game.add("player");
            game.add("player");

            Assert.That(game.howManyPlayers(), Is.EqualTo(2));
        }

        [Test]
        public void MaximumOfSixPlayers()
        {
            var players = new int[5];
            var game = new Game();

            foreach (var p in players)
            {
                game.add(p.ToString());
            }

            Assert.Throws<IndexOutOfRangeException>(delegate { game.add("too many players"); });
        }
    }
}
