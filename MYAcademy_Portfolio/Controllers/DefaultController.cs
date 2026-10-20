using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}