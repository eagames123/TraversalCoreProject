using System.Collections.Generic;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnouncemetDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncemetController : Controller
    {
        private IAnnouncemetService _announcemetService;

        public AnnouncemetController(IAnnouncemetService announcemetService)
        {
            _announcemetService = announcemetService;
        }

        public IActionResult Index()
        {
            List<Announcemet> values = _announcemetService.TGetList();  
            List<AnnouncemetViewModel> models = new List<AnnouncemetViewModel>();
            foreach (var item in values)
            {
                AnnouncemetViewModel model = new AnnouncemetViewModel();
                model.Id = item.AnnouncemetId;
                model.Title = item.Title;
                model.Content = item.Content;
                models.Add(model);
            }
            return View(models);
        }

        [HttpGet]
        public IActionResult AddAnnouncemet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncemet(AnnouncemetAddDTO announcemet)
        {
            return View();
        }

    }
}
