using Model;
using Model.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IAccountService
    {
        List<AccountViewModel> GetAccounts();
        Account GetAccountByID(int ID);
        void CreateAccount(Account Account);
        void EditAccount(Account Account);
        void RemoveAccount(int AccountId);
        void SaveAccount();
        int CountNoOfSearches(int ID);
        IPagedList<AccountViewModel> FilterAccounts(SearchViewModel Filter, int page);
        IPagedList<AccountViewModel> GeneralSearch(GeneralSearchView Filter, int page);
        List<AccountViewModel> GetLastNAccounts(int N);
        Account GetAccountByName(string FirstName, string LastName);
    }
}
