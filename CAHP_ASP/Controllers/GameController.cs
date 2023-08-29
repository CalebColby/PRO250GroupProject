using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CAHP_ASP.Controllers
{
    public class GameController : Controller
    {
        public bool IsHost { private set; get; } = false;


        public IActionResult Lobby()
        {
            var ipAddress = Dns.GetHostName();

            return View();
        }
    }
}
