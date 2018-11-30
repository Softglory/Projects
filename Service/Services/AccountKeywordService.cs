using Data.Infrastructure;
using Data.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class AccountKeywordService : IAccountKeywordService
    {
        private readonly IAccountKeywordRepository AccountKeywordRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountKeywordService(IAccountKeywordRepository AccountKeywordRepository, IUnitOfWork unitOfWork)
        {
            this.AccountKeywordRepository = AccountKeywordRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<AccountKeyword> GetAccountKeywords()
        {
            List<AccountKeyword> AccountKeywords = AccountKeywordRepository.GetAll().ToList();
            return AccountKeywords;
        }

        public AccountKeyword GetAccountKeywordByID(int ID)
        {
            AccountKeyword AccountKeyword = AccountKeywordRepository.GetByID(ID);
            return AccountKeyword;
        }

        public void CreateAccountKeyword(AccountKeyword AccountKeyword)
        {
            AccountKeyword.CreatedOn = DateTime.Now;
            AccountKeyword.ModifiedOn = DateTime.Now;

            AccountKeywordRepository.Add(AccountKeyword);
            SaveAccountKeyword();
        }

        public void EditAccountKeyword(AccountKeyword AccountKeyword)
        {
            AccountKeyword.ModifiedOn = DateTime.Now;
            AccountKeywordRepository.Edit(AccountKeyword.AccountKeywordId, AccountKeyword);
            SaveAccountKeyword();
        }

        public void SaveAccountKeyword()
        {
            unitOfWork.Commit();
        }


    }
}
