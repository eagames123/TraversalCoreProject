using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AppUserManager:IAppUserService
    {
        private IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Tadd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void Delete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
