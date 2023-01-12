using System.Collections.Generic;
using BusinessLayer.Abstract.AbstractUnitOfWork;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete.ConcreteUnitOfWork
{
    public class AccountManager:IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IUnitOfWorkDal unitOfWorkDal, IAccountDal accountDal)
        {
            _unitOfWorkDal = unitOfWorkDal;
            _accountDal = accountDal;
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public Account TGetById(int id)
        {
            return _accountDal.GetByID(id);
        }
    }
}
