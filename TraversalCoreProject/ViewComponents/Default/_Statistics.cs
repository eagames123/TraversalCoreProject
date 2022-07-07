using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.Destination = c.Destinations.Count();
            ViewBag.Guide = c.Guides.Count();
            ViewBag.v3 = "300";
            return View();
        }
    }
}
