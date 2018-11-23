using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using PagedList;
using Service;

namespace Arab_Monteral.Controllers
{
    public class SearchController : Controller
    {
        private readonly IAccountService AccountService;
        public SearchController(IAccountService accountService)
        {
            this.AccountService = accountService;
        }

        // GET: 
        public ActionResult Results(SearchViewModel Filter,int? page)
        {
            IPagedList<AccountViewModel> Accounts = AccountService.FilterAccounts(Filter,page??1);
     
            return View("Results",Accounts);
        }

        public ActionResult GeneralSearch(GeneralSearchView Filter, int? page)
        {
            IPagedList<AccountViewModel> Accounts = AccountService.GeneralSearch(Filter, page ?? 1);

            return View("Results", Accounts);
        }

    }
}