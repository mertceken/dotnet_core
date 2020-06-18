using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logic.Layer;

namespace api_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GameRepository _repository = new GameRepository();

        // GET api/games
        [HttpGet]
        public ActionResult<IEnumerable<GameState>> LoadGame()
        {
            return Ok(_repository.Games);
        }

        // GET api/games/42
        [HttpGet("{id}")]
        public ActionResult<GameState> LoadGame(int id)
        {
            var game = _repository.GetGame(id);

            if (game != null)
            {
                return Ok(game);
            }

            return new NotFoundResult();
        }

        // POST api/games
        [HttpPost]
        public CreatedResult NewGame()
        {
            var game = _repository.CreateNewGame();

            return new CreatedResult($"/api/games/{game.Id}", game);
        }

        // DELETE api/games/42
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(int id)
        {
            bool deleted = _repository.DeleteGame(id);

            if (deleted)
            {
                return new StatusCodeResult(StatusCodes.Status204NoContent);
            }

            return new NotFoundResult();
        }
    }
}