using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        private GuideManager _guideManager = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = _guideManager.TGetList();
            return View(values);
        }

    }
}
