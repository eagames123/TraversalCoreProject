using System.Collections.Generic;
using System.Linq;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            List<AppRole> values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<AppRole> values = _roleManager.Roles.ToList();
            return View(values);
        }

    }
}
