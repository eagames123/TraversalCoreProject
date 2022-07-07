using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Tadd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
