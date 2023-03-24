using Microsoft.AspNetCore.Mvc;

namespace FormationMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }
    }
}
