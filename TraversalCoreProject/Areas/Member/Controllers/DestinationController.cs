using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            List<Destination> destinationsList = _destinationManager.TGetList();
            return View(destinationsList);
        }
    }
}
