using Data.Infrastructure;
using Data.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository CompanyRepository;
        private readonly IUnitOfWork unitOfWork;

        public CompanyService(ICompanyRepository CompanyRepository, IUnitOfWork unitOfWork)
        {
            this.CompanyRepository = CompanyRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<Company> GetCompanys()
        {
            List<Company> Companys = CompanyRepository.GetAll().ToList();
            return Companys;
        }

        public Company GetCompanyByID(int ID)
        {
            Company Company = CompanyRepository.GetByID(ID);
            return Company;
        }

        public void CreateCompany(Company Company)
        {
            Company Exists = CompanyRepository.Get(x => x.Email == Company.Email).FirstOrDefault();
            if (Exists != null)
            {
                throw new Exception("Company already exists");
            }
            Company.CreatedOn = DateTime.Now;
            Company.ModifiedOn = DateTime.Now;

            CompanyRepository.Add(Company);
            SaveCompany();
        }

        public void EditCompany(Company Company)
        {
            Company.ModifiedOn = DateTime.Now;
            CompanyRepository.Edit(Company.CompanyId, Company);
            SaveCompany();
        }

        public void SaveCompany()
        {
            unitOfWork.Commit();
        }


    }
}
