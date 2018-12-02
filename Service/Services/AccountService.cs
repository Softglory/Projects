using Data.Infrastructure;
using Data.Repositories;
using Model;
using Model.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository AccountRepository;
        private readonly ISearchCountRepository SearchCountRepository;
        private readonly IAccountKeywordRepository AccountKeywordRepository;
        private readonly IAccountServiceRepository AccountServiceRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountService(IAccountRepository AccountRepository, ISearchCountRepository SearchCountRepository, IAccountKeywordRepository AccountKeywordRepository, IAccountServiceRepository AccountServiceRepository, IUnitOfWork unitOfWork)
        {
            this.AccountRepository = AccountRepository;
            this.SearchCountRepository = SearchCountRepository;
            this.AccountKeywordRepository = AccountKeywordRepository;
            this.AccountServiceRepository = AccountServiceRepository;
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
            //get Account keywords
            Account.Keywords = AccountKeywordRepository.Get(x => x.AccountId == ID).ToList();
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

            //Add key words
            foreach (var word in Account.Keywords)
            {
                word.CreatedOn = DateTime.Now;
                word.ModifiedOn = DateTime.Now;
                word.Status = true;
                AccountKeywordRepository.Add(word);
            }
            SaveAccount();
        }

        public void EditAccount(Account Account)
        {
            Account.ModifiedOn = DateTime.Now;
            if (Account.CardImage == null) // no new image choosen
            {
                Account.CardImage = AccountRepository.GetByID(Account.AccountId).CardImage;
            }
          
            //update keywords 
            //1- delete all account key words
            //2- Add key words
            foreach (var word in Account.Keywords)
            {
                AccountKeyword newWord = new AccountKeyword()
                {
                    AccountId = Account.AccountId,
                    KeyWord = word.KeyWord,
                    Status = word.Status,
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now
                };

                AccountKeywordRepository.Delete(word);
                
                AccountKeywordRepository.Add(newWord);
            }

            Account.Keywords = null;
            AccountRepository.Edit(Account.AccountId, Account);
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

        public List<Model.AccountService> GetAccountServices(int AccountId)
        {
            List<Model.AccountService> AccountServices = AccountServiceRepository.Get(x => x.AccountId == AccountId).Include("Service").ToList();
            return AccountServices;
        }

        public IPagedList<AccountViewModel> FilterAccounts(SearchViewModel Filter,int page)
        {
            List<Account> Accounts = new List<Account>();
            Accounts = AccountRepository.Get(x => (x.FirstName == Filter.FirstName || String.IsNullOrEmpty(Filter.FirstName))
                                    && (x.LastName == Filter.LastName || String.IsNullOrEmpty(Filter.LastName))
                                    && (x.Location == Filter.Location || String.IsNullOrEmpty(Filter.Location))
                                    && (x.Phone == Filter.Phone || String.IsNullOrEmpty(Filter.Phone))
                                                  && x.Status == true).ToList();
           
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
            List<Account> Accounts = AccountRepository.GetAll().AsEnumerable().Reverse().Where(x=>x.CardImage != null && x.Status == true).Take(N).Reverse().ToList();
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

        public IPagedList<AccountViewModel> AccountRequests(int page)
        {
            List<Account> Accounts = new List<Account>();
            Accounts = AccountRepository.Get(x => x.Status == false).ToList();

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

        public void ConfirmRequest(int ID)
        {
            //1- set account status to true 
            Account Account = AccountRepository.GetByID(ID);
            Account.Status = true;
            Account.Keywords = null;
            AccountRepository.Edit(Account.AccountId, Account);
            SaveAccount();
            //2- send confirmation mail to user 
            SendMail("Arab Montreal Confimation", "Congratulations! After reviewig your information , your sccount has been accepted.", Account.Email);
        }

        public void JoinRequestMail(int ID)
        {
            Account Account = AccountRepository.GetByID(ID);
            //1- send mail to Admin
            SendMail("Arab Montreal Request", "A new Account request is waiting for your confirmation.", "arabmontreal5@gmail.com");
            //2- send mail to user 
            SendMail("Arab Montreal Request", "Thanks for taking your time to fill the join form. The Admin will review your info and will send you a confirmation letter once accepted.", Account.Email);
        }

        public void SendMail(string Subject, string Body, string ToMail)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("arabmontreal5@gmail.com");
            mail.To.Add(ToMail);
            mail.Subject = Subject;
            mail.Body = Body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("arabmontreal5@gmail.com", "Admin123!");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
