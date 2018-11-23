using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.ViewModels;
using Service;

namespace Arab_Monteral.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountService AccountService;
        public HomeController(IAccountService accountService)
        {
            this.AccountService = accountService;
        }
        public ActionResult Index()
        {
            List<AccountViewModel> Accounts = AccountService.GetLastNAccounts(10);
            return View(Accounts);
        }

    }
}