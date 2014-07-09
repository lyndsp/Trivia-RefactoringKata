using NUnit.Framework;
using System;

namespace UglyTrivia
{
    [TestFixture]
    class Roll
    {
        Game game;

        [SetUp]
        public void CreateNewGame()
        {
            game = new Game();
        }

    }
}
