using Microsoft.AspNetCore.Mvc;

namespace Top_5.Controllers
{
    public class Top5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
