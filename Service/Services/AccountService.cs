using Data.Infrastructure;
using Data.Repositories;
using Model;
using Model.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository AccountRepository;
        private readonly ISearchCountRepository SearchCountRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountService(IAccountRepository AccountRepository, ISearchCountRepository SearchCountRepository, IUnitOfWork unitOfWork)
        {
            this.AccountRepository = AccountRepository;
            this.SearchCountRepository = SearchCountRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<AccountViewModel> GetAccounts()
        {
            List<Account> Accounts = AccountRepository.GetAll().ToList();
            List<AccountViewModel> AccountsView = new List<AccountViewModel>();
            foreach (Model.Account Acc in Accounts)
            {
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
                    Status = Acc.Status,
                    CreatedOn = Acc.CreatedOn,
                    ModifiedOn = Acc.ModifiedOn,
                    Company = Acc.Company,
                    NoOfSearches = CountNoOfSearches(Acc.AccountId)
                };
                AccountsView.Add(AccView);
            }

            return AccountsView;
        }

        public Account GetAccountByID(int ID)
        {
            Account Account = AccountRepository.GetByID(ID);
            return Account;
        }

        public void CreateAccount(Account Account)
        {
            Account Exists = AccountRepository.Get(x => x.FirstName == Account.FirstName && x.LastName == Account.LastName).FirstOrDefault();
            if (Exists != null)
            {
                throw new Exception("Account already exists");
            }

            Account.CreatedOn = DateTime.Now;
            Account.ModifiedOn = DateTime.Now;
            AccountRepository.Add(Account);
            SaveAccount();
        }

        public void EditAccount(Account Account)
        {
            Account.ModifiedOn = DateTime.Now;
            if (Account.CardImage == null) // no new image choosen
            {
                Account.CardImage = AccountRepository.GetByID(Account.AccountId).CardImage;
            }
            AccountRepository.Edit(Account.AccountId,Account);
           SaveAccount();
        }

        public void RemoveAccount(int AccountId)
        {
            Account Account = AccountRepository.GetByID(AccountId);
            Account.Status = false;
            AccountRepository.Edit(Account.AccountId, Account);
            SaveAccount();
        }

        public void SaveAccount()
        {
            unitOfWork.Commit();
        }


        public int CountNoOfSearches(int ID)
        {
            int count = 0;
            count = SearchCountRepository.Get(x => x.AccountId == ID).Count();
            return count;
        }

        public IPagedList<AccountViewModel> FilterAccounts(SearchViewModel Filter,int page)
        {
            List<Account> Accounts = new List<Account>();
            Accounts = AccountRepository.Get(x => (x.FirstName == Filter.FirstName || String.IsNullOrEmpty(Filter.FirstName))
                                    && (x.LastName == Filter.LastName || String.IsNullOrEmpty(Filter.LastName))
                                    && (x.Location == Filter.Location || String.IsNullOrEmpty(Filter.Location))
                                    && (x.Phone == Filter.Phone || String.IsNullOrEmpty(Filter.Phone))).ToList();
           
            List<AccountViewModel> AccountsView = new List<AccountViewModel>();
            foreach (Model.Account Acc in Accounts)
            {
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
                    Status = Acc.Status,
                    CreatedOn = Acc.CreatedOn,
                    ModifiedOn = Acc.ModifiedOn,
                    Company = Acc.Company,
                    NoOfSearches = CountNoOfSearches(Acc.AccountId)
                };
                AccountsView.Add(AccView);
            }

            int PageSize = 5;
            IPagedList<AccountViewModel> PagedResults = AccountsView.ToPagedList(page, PageSize);//paging 
          
            return PagedResults;
        }

        public IPagedList<AccountViewModel> GeneralSearch(GeneralSearchView Filter, int page)
        {
            List<Account> Accounts = new List<Account>();
            Accounts = AccountRepository.Get(x => (x.FirstName == Filter.SearchKeyWord ||
                                                   x.LastName == Filter.SearchKeyWord ||
                                                   x.Location == Filter.SearchKeyWord ||
                                                   x.Phone == Filter.SearchKeyWord) ||
                                                   String.IsNullOrEmpty(Filter.SearchKeyWord)).ToList();
                                                  
            List<AccountViewModel> AccountsView = new List<AccountViewModel>();
            foreach (Model.Account Acc in Accounts)
            {
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
                    Status = Acc.Status,
                    CreatedOn = Acc.CreatedOn,
                    ModifiedOn = Acc.ModifiedOn,
                    Company = Acc.Company,
                    NoOfSearches = CountNoOfSearches(Acc.AccountId)
                };
                AccountsView.Add(AccView);
            }

            int PageSize = 5;
            IPagedList<AccountViewModel> PagedResults = AccountsView.ToPagedList(page, PageSize);//paging 

            return PagedResults;
        }

        public List<AccountViewModel> GetLastNAccounts(int N)
        {
            List<Account> Accounts = AccountRepository.GetAll().AsEnumerable().Reverse().Where(x=>x.CardImage != null).Take(N).Reverse().ToList();
            List<AccountViewModel> AccountsView = new List<AccountViewModel>();
            foreach (Model.Account Acc in Accounts)
            {
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
                    Status = Acc.Status,
                    CreatedOn = Acc.CreatedOn,
                    ModifiedOn = Acc.ModifiedOn,
                    Company = Acc.Company,
                    NoOfSearches = CountNoOfSearches(Acc.AccountId)
                };
                AccountsView.Add(AccView);
            }
            return AccountsView;
        }

        public Account GetAccountByName(string FirstName, string LastName)
        {
            Account Acc = AccountRepository.Get(x => x.FirstName == FirstName && x.LastName == LastName).FirstOrDefault();
            return Acc;
        }
    }
}
