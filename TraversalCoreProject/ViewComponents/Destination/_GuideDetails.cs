using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _GuideDetails:ViewComponent
    {
        private IGuideService _guideService;

        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }



        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetById(1);
            return View(values);
        }

    }
}
