using System.Collections.Generic;
using BusinessLayer.Abstract.AbstractUnitOfWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valueSender = _accountService.TGetById(accountViewModel.SenderId);
            var valueReceiver = _accountService.TGetById(accountViewModel.ReciverId);

            valueSender.Balance -= accountViewModel.Amount;
            valueReceiver.Balance += accountViewModel.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }


    }
}
