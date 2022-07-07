using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        private FeatureManager _featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            //var values = _featureManager.TGetList();

            //ViewBag.image1=_featureManager.get

            return View();
        }
    }
}
