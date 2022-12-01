using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            //var jsonCity = JsonConvert.SerializeObject(cities);
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;

            _destinationService.Tadd(destination);

            var values = JsonConvert.SerializeObject(destination);
            
            return Json(values);
        }

        public IActionResult GetById(int DestionationId)
        {
            var values = _destinationService.TGetById(DestionationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.Delete(values);
            //var jsonValues = JsonConvert.SerializeObject(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.Update(destination);
            var jsonValues = JsonConvert.SerializeObject(destination);
            return Json(jsonValues);
        }

        //public static List<CityClass> cities = new List<CityClass>()
        //{
        //    new CityClass() { CityId = 1, CityName = "İstanbul", CityCountry = "Türkiye" },
        //    new CityClass() { CityId = 2, CityName = "Ankara", CityCountry = "Türkiye" },
        //    new CityClass() { CityId = 3, CityName = "İzmir", CityCountry = "Türkiye" },
        //    new CityClass() { CityId = 4, CityName = "Atina", CityCountry = "YUnanistan" },
        //    new CityClass() { CityId = 5, CityName = "Paris", CityCountry = "Fransa" },
        //    new CityClass() { CityId = 6, CityName = "Moskova", CityCountry = "Rusya" },
        //    new CityClass() { CityId = 7, CityName = "Bakü", CityCountry = "Azerbeycan" },
        //    new CityClass() { CityId = 8, CityName = "Miami", CityCountry = "Amerika" },
        //    new CityClass() { CityId = 9, CityName = "Utah", CityCountry = "Amerika" }
        //};


    }
}
