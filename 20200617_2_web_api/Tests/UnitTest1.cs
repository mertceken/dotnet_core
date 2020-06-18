using NUnit.Framework;
using System.Linq;
using Logic.Layer;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void RepositoryShouldStartWithGameState()
        {
            // Arrange
            var repository = new GameRepository();

            // Act
            var games = repository.Games;

            // Assert
            Assert.Greater(games.Count(), 0);
        }
    }
}
