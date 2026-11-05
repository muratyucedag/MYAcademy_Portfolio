using Microsoft.AspNetCore.Mvc;
using MYAcademy_Portfolio.Context;

namespace MYAcademy_Portfolio.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeroSectionComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;
        public _DefaultHeroSectionComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.HeroSections.FirstOrDefault();
            ViewBag.v1 = values.Title;
            ViewBag.v2 = values.SubTitle;
            ViewBag.v3 = values.Description;
            ViewBag.v4 = values.ImageUrl;
            return View();
        }
    }
}
