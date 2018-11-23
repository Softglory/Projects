using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface ICompanyService
    {
        List<Company> GetCompanys();
        Company GetCompanyByID(int ID);
        void CreateCompany(Company Company);
        void EditCompany(Company Company);
        void SaveCompany();
    }
}
