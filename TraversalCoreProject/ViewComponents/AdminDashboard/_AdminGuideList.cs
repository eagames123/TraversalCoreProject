using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminGuideList:ViewComponent
    {
        private Context c = new Context();

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
