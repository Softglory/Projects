using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.ViewModels;
using System.IO;
using Model;
using PagedList;

namespace Arab_Monteral.Controllers
{

 
    public class AccountsController : Controller
    {
        private readonly IAccountService AccountService;
        public AccountsController(IAccountService accountService)
        {
            this.AccountService = accountService;
        }

        // GET: Accounts
        [Authorize(Roles = "Admin")]
        public ActionResult Index(int? page)
        {
            List<AccountViewModel> Accounts = AccountService.GetAccounts();
            SearchViewModel EmptySearch = new SearchViewModel();
            IPagedList<AccountViewModel> PagedAccounts = AccountService.FilterAccounts(EmptySearch, page ?? 1);
            return View(PagedAccounts);
        }

  
        public ActionResult AccountProfile(int ID)
        {
            Model.Account Acc = AccountService.GetAccountByID(ID);
            AccountViewModel AccView = new AccountViewModel()
            {
                AccountId = Acc.AccountId,
                FirstName = Acc.FirstName,
                LastName = Acc.LastName,
                CardImage = Acc.CardImage,
                ProfessionTitle = Acc.ProfessionTitle,
                Phone = Acc.Phone,
                CompanyId = Acc.CompanyId,
                Location = Acc.Location,
                FacebookUrl = Acc.FacebookUrl,
                TwitterUrl = Acc.TwitterUrl,
                Website = Acc.Website,
                Status = Acc.Status,
                CreatedOn = Acc.CreatedOn,
                ModifiedOn = Acc.ModifiedOn,
                Company = Acc.Company
            };
            AccView.NoOfSearches = AccountService.CountNoOfSearches(ID);
            AccView.AccountServices = AccountService.GetAccountServices(ID);
            return View(AccView);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create(int? ID)
        {
            if (ID != null) //edit
            {
                Model.Account Acc = AccountService.GetAccountByID(ID ?? 0);
              
                AccountViewModel AccView = new AccountViewModel()
                {
                    AccountId = Acc.AccountId,
                    FirstName = Acc.FirstName,
                    LastName = Acc.LastName,
                    CardImage = Acc.CardImage,
                    ProfessionTitle = Acc.ProfessionTitle,
                    Phone = Acc.Phone,
                    CompanyId = Acc.CompanyId,
                    Location = Acc.Location,
                    FacebookUrl = Acc.FacebookUrl,
                    TwitterUrl = Acc.TwitterUrl,
                    Website = Acc.Website,
                    Status = Acc.Status,
                    CreatedOn = Acc.CreatedOn,
                    ModifiedOn = Acc.ModifiedOn,
                    Company = Acc.Company,
                    Keywords = Acc.Keywords
                };
                return View(AccView);
            }
            return View(new AccountViewModel());
        }

        // POST: Account/Create/ID
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(AccountViewModel AccountView, int? ID, HttpPostedFileBase file)
        {
            if (ID == null)
            {
                AccountView.CreatedOn = DateTime.Now;
            }
    
            AccountView.ModifiedOn = DateTime.Now;
            ModelState.Clear();
            TryValidateModel(AccountView);

            if (ModelState.IsValid)
            {
                //upload File
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                    file.SaveAs(path);

                    fileName = Path.GetFileName(path);
                    AccountView.CardImage = "Uploads/" + fileName;
                }

                Model.Account Acc = new Account()
                {
                    AccountId = AccountView.AccountId,
                    FirstName = AccountView.FirstName,
                    LastName = AccountView.LastName,
                    CardImage = AccountView.CardImage,
                    ProfessionTitle = AccountView.ProfessionTitle,
                    Phone = AccountView.Phone,
                    CompanyId = AccountView.CompanyId,
                    Location = AccountView.Location,
                    FacebookUrl = AccountView.FacebookUrl,
                    TwitterUrl = AccountView.TwitterUrl,
                    Website = AccountView.Website,
                    Status = AccountView.Status,
                    CreatedOn = AccountView.CreatedOn,
                    ModifiedOn = AccountView.ModifiedOn,
                    Company = AccountView.Company,
                    Keywords = AccountView.Keywords
                };

                if (ID == null) //add
                {
                    AccountService.CreateAccount(Acc);
                    Acc = AccountService.GetAccountByName(Acc.FirstName, Acc.LastName);
                }
                else //update
                {
                    Acc.AccountId = ID ?? 0;
                    AccountService.EditAccount(Acc);
                }

                return Redirect("~/Accounts/Details/" + Acc.AccountId);
            }

            return View(AccountView);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(int ID)
        {
          Model.Account Acc = AccountService.GetAccountByID(ID);
          AccountViewModel AccView = new AccountViewModel()
          {
              AccountId = Acc.AccountId,
              FirstName = Acc.FirstName,
              LastName = Acc.LastName,
              CardImage = Acc.CardImage,
              ProfessionTitle = Acc.ProfessionTitle,
              Phone = Acc.Phone,
              CompanyId = Acc.CompanyId,
              Location = Acc.Location,
              FacebookUrl = Acc.FacebookUrl,
              TwitterUrl = Acc.TwitterUrl,
              Website = Acc.Website,
              Status = Acc.Status,
              CreatedOn = Acc.CreatedOn,
              ModifiedOn = Acc.ModifiedOn,
              Company = Acc.Company,
              Keywords = Acc.Keywords
          };
          return View(AccView);
       
        }

        [Authorize(Roles = "Admin")]
        public ActionResult OldProfile(int ID)
        {
            Model.Account Acc = AccountService.GetAccountByID(ID);
            AccountViewModel AccView = new AccountViewModel()
            {
                AccountId = Acc.AccountId,
                FirstName = Acc.FirstName,
                LastName = Acc.LastName,
                CardImage = Acc.CardImage,
                ProfessionTitle = Acc.ProfessionTitle,
                Phone = Acc.Phone,
                CompanyId = Acc.CompanyId,
                Location = Acc.Location,
                FacebookUrl = Acc.FacebookUrl,
                TwitterUrl = Acc.TwitterUrl,
                Website = Acc.Website,
                Status = Acc.Status,
                CreatedOn = Acc.CreatedOn,
                ModifiedOn = Acc.ModifiedOn,
                Company = Acc.Company
            };
            AccView.NoOfSearches = AccountService.CountNoOfSearches(ID);
            return View(AccView);
        }

        public ActionResult JoinAccount()
        {
            return View(new AccountViewModel());
        }


        [HttpPost]
        public ActionResult JoinRequest(AccountViewModel AccountView,HttpPostedFileBase file)
        {
            AccountView.CreatedOn = DateTime.Now;
            AccountView.ModifiedOn = DateTime.Now;
            ModelState.Clear();
            TryValidateModel(AccountView);

            if (ModelState.IsValid)
            {
                //upload File
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                    file.SaveAs(path);

                    fileName = Path.GetFileName(path);
                    AccountView.CardImage = "Uploads/" + fileName;
                }

                Model.Account Acc = new Account()
                {
                    AccountId = AccountView.AccountId,
                    FirstName = AccountView.FirstName,
                    LastName = AccountView.LastName,
                    CardImage = AccountView.CardImage,
                    ProfessionTitle = AccountView.ProfessionTitle,
                    Phone = AccountView.Phone,
                    CompanyId = AccountView.CompanyId,
                    Location = AccountView.Location,
                    FacebookUrl = AccountView.FacebookUrl,
                    TwitterUrl = AccountView.TwitterUrl,
                    Website = AccountView.Website,
                    Status = false,
                    CreatedOn = AccountView.CreatedOn,
                    ModifiedOn = AccountView.ModifiedOn,
                    Company = AccountView.Company,
                    Keywords = AccountView.Keywords,
                    Email = AccountView.Email,
                    FirstNameEn = AccountView.FirstNameEn,
                    LastNameEn = AccountView.LastNameEn
                };

                AccountService.CreateAccount(Acc);
                Acc = AccountService.GetAccountByName(Acc.FirstName, Acc.LastName);

                //send email to both the user and the admin 
                AccountService.JoinRequestMail(Acc.AccountId);

                ViewBag.ConfirmMessage = "An Email has been sent to you";
                return Redirect("~/Home/Index/");
            }

            return View(AccountView);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult AccountRequests(int? page)
        {
            List<AccountViewModel> Accounts = AccountService.GetAccounts();
            SearchViewModel EmptySearch = new SearchViewModel();
            IPagedList<AccountViewModel> PagedAccounts = AccountService.AccountRequests(page ?? 1);
            return View(PagedAccounts);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult ConfirmRequest(int ID)
        {
            AccountService.ConfirmRequest(ID);
            
            IPagedList<AccountViewModel> PagedAccounts = AccountService.AccountRequests(1);
            return View("AccountRequests", PagedAccounts);
        }
    }
}