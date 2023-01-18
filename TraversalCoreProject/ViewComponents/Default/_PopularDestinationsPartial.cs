using System.Collections.Generic;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        private readonly DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            List<EntityLayer.Concrete.Destination> values = _destinationManager.TGetList();

            return View(values);
        }
    }
}
