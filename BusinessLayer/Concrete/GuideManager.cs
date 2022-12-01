using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GuideManager:IGuideService
    {
        private IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Tadd(Guide t)
        {
           _guideDal.Insert(t);
        }

        public void Delete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public void Update(Guide t)
        {
            _guideDal.Update(t);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }
    }
}
