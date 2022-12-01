using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();

            return View(values);
        }

        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.Tadd(destination);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.Delete(values);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {

            _destinationService.Update(destination);
            return RedirectToAction("Index");
        }

    }
}
