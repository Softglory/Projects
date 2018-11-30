using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IAccountKeywordService
    {
        List<AccountKeyword> GetAccountKeywords();
        AccountKeyword GetAccountKeywordByID(int ID);
        void CreateAccountKeyword(AccountKeyword AccountKeyword);
        void EditAccountKeyword(AccountKeyword AccountKeyword);
        void SaveAccountKeyword();
    }
}
