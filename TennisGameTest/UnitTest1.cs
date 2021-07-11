using NUnit.Framework;

namespace TennisGameTest
{
    public class Tests
    {
        private TennisGame _tennisGame = new TennisGame();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }

        [Test]
        public void Thirty_All()
        {
            Assert.AreEqual("Thirty_All", _tennisGame.Score());
        }
    }
}