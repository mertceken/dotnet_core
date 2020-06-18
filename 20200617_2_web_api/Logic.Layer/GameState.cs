using System;

namespace Logic.Layer
{
    public class GameState
    {

        public GameState(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public int ClosedCount { get; set; }
    }
}
