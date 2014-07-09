using NUnit.Framework;

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
    }
}
