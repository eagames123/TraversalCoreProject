using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class About2Manager:IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void Tadd(About2 t)
        {
          _about2Dal.Insert(t);
        }

        public void Delete(About2 t)
        {
            _about2Dal.Delete(t);
        }

        public void Update(About2 t)
        {
            _about2Dal.Update(t);
        }

        public List<About2> TGetList()
        {
            _about2Dal.GetList();
            return null;
        }

        public About2 TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
