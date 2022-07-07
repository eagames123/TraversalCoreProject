using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

        private readonly ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());

        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from destination in _destinationManager.TGetList()
                                           select new SelectListItem()
                                           {
                                               Text = destination.City,
                                               Value = destination.DestinationId.ToString()
                                           }).ToList();

            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 7;
            reservation.Status = "Onay Bekliyor";
            _reservationManager.Tadd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }

    }
}
