using System.Collections.Generic;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {

        private readonly DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            List<Destination> destinations = _destinationManager.TGetList();

            return View(destinations);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = _destinationManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }

    }
}
