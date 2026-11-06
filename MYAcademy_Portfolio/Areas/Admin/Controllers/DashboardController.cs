using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;

namespace MYAcademy_Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly PortfolioContext _context;
        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.messageCount = _context.Messages.Count();
            ViewBag.messageReadByTrueCount = _context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.messageReadByFalseCount = _context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
