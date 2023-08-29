using Microsoft.AspNetCore.Mvc;

namespace CAHP_ASP.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
