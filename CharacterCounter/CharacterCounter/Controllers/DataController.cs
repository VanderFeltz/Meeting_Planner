using Microsoft.AspNetCore.Mvc;

namespace CharacterCounter.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
