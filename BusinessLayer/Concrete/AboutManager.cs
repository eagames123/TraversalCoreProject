using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        //Constructor Dependency Injection
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Tadd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }

        public List<About> TGetList()
        {
            _aboutDal.GetList();
            return null;
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
