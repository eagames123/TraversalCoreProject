using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager:ISubAboutService
    {
        private ISubAboutDal _subaboutDal;

        public SubAboutManager(ISubAboutDal subaboutDal)
        {
            _subaboutDal = subaboutDal;
        }

        public void Tadd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subaboutDal.GetList();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
