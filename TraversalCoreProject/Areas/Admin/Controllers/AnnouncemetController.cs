using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.EMMA;
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
        private IMapper _mapper;


        public AnnouncemetController(IAnnouncemetService announcemetService, IMapper mapper)
        {
            _announcemetService = announcemetService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //List<Announcemet> values = _announcemetService.TGetList();  
            //List<AnnouncemetViewModel> models = new List<AnnouncemetViewModel>();
            //foreach (var item in values)
            //{
            //    AnnouncemetViewModel model = new AnnouncemetViewModel();
            //    model.Id = item.AnnouncemetId;
            //    model.Title = item.Title;
            //    model.Content = item.Content;
            //    models.Add(model);
            //}
            var values = _mapper.Map<List<AnnouncemetListDTO>>(_announcemetService.TGetList());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncemet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncemet(AnnouncemetAddDTO announcemet)
        {
            if (ModelState.IsValid)
            {
                _announcemetService.Tadd(new Announcemet()
                {
                    Content = announcemet.Content,
                    Title = announcemet.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                    });
                return RedirectToAction("Index");
            }
            return View(announcemet);
        }

        public IActionResult DeleteAnnouncemet(int id)
        {
            var values = _announcemetService.TGetById(id);
            _announcemetService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncemet(int id)
        {
            var values = _mapper.Map<AnnouncemetUpdateDTO>(_announcemetService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncemet(AnnouncemetUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcemetService.Update(new Announcemet()
                {
                    AnnouncemetId = model.AnnouncemetId,
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}
