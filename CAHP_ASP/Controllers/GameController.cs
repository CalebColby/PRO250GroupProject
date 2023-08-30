using CAHP_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CAHP_ASP.Controllers
{
    public class GameController : Controller
    {
        public bool IsHost { private set; get; } = false;
        public GameData _gameData { private set; get; } = new GameData();

        public IActionResult Lobby()
        {
            _gameData.Players.Add(new Player("Host"));
            IsHost = true;

            return View(_gameData);
        }

        [HttpPost("JoinLobby")]
        public IActionResult JoinLobby(Player player)
        {
            _gameData.Players.Add(player);

            return View(_gameData);
        }

        public IActionResult GameAction()
        {


            throw new NotImplementedException();
        }
    }
}
