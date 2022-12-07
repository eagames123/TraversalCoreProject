using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AnnouncemetManager:IAnnouncemetService
    {
        private IAnnouncemetDal _announcemetDal;

        public AnnouncemetManager(IAnnouncemetDal announcemetDal)
        {
            _announcemetDal = announcemetDal;
        }

        public void Tadd(Announcemet t)
        {
            _announcemetDal.Insert(t);
        }

        public void Delete(Announcemet t)
        {
            _announcemetDal.Delete(t);
        }

        public void Update(Announcemet t)
        {
            _announcemetDal.Update(t);
        }

        public List<Announcemet> TGetList()
        {
           return _announcemetDal.GetList();
        }

        public Announcemet TGetById(int id)
        {
          return  _announcemetDal.GetById(id);
        }
    }
}
