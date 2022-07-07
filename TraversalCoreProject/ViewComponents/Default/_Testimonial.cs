using System.Collections.Generic;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        private TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            List<Testimonial> values = _testimonialManager.TGetList();
            return View(values);
        }
    }
}
