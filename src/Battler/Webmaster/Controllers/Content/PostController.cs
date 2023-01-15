using Microsoft.AspNetCore.Mvc;

namespace Battler.Webmaster.Controllers.Content
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
