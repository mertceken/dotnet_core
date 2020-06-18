using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Logic.Layer
{
    public class GameRepository
    {
        private readonly IList<GameState> _games = new List<GameState>();

        public GameRepository()
        {
            // Start with some sample data
            CreateNewGame();
        }

        public IEnumerable<GameState> Games => _games;

        public GameState GetGame(int id) => _games.FirstOrDefault(g => g.Id == id);

        public GameState CreateNewGame()
        {
            int id = _games.Count + 1;
            var game = new GameState(id);
            _games.Add(game);

            return game;
        }

        public bool DeleteGame(int id)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);

            return game != null && _games.Remove(game);
        }
    }
}
