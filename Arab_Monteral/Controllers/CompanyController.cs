using Model;
using Model.ViewModels;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arab_Monteral.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService CompanyService;
        public CompanyController(ICompanyService companyService)
        {
            this.CompanyService = companyService;
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index(int? page)
        {
            List<Company> Companies = CompanyService.GetCompanys();
           
            return View(Companies);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Create(int? ID)
        {
            if (ID != null) //edit
            {
                Model.Company comp = CompanyService.GetCompanyByID(ID ?? 0);
                CompanyViewModel AccView = new CompanyViewModel()
                {
                    CompanyId = comp.CompanyId,
                    CompanyName = comp.CompanyName, 
                    AboutUs = comp.AboutUs,
                    Address1 = comp.Address1,
                    Address2 = comp.Address2,
                    Phone1 = comp.Phone1,
                    Phone2 = comp.Phone2,
                    Fax = comp.Fax,
                    Email = comp.Email,
                    CreatedOn = comp.CreatedOn,
                    ModifiedOn = comp.ModifiedOn
                };
                return View(AccView);
            }
            return View();
        }

        // POST: Company/Create/ID
        [HttpPost]
        public ActionResult Create(CompanyViewModel CompanyView, int? ID)
        {

            if (ModelState.IsValid)
            {
                Model.Company comp = new Company()
                {
                    CompanyId = CompanyView.CompanyId,
                    CompanyName = CompanyView.CompanyName,
                    AboutUs = CompanyView.AboutUs,
                    Address1 = CompanyView.Address1,
                    Address2 = CompanyView.Address2,
                    Phone1 = CompanyView.Phone1,
                    Phone2 = CompanyView.Phone2,
                    Fax = CompanyView.Fax,
                    Email = CompanyView.Email,
                    CreatedOn = CompanyView.CreatedOn,
                    ModifiedOn = CompanyView.ModifiedOn
                };

                if (ID == null) //add
                {
                    CompanyService.CreateCompany(comp);
                }
                else //update
                {
                    comp.CompanyId = ID??0;
                    CompanyService.EditCompany(comp);
                }

                return Redirect("~/Company/Details/" + comp.CompanyId);
            }

            return View(CompanyView);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(int ID)
        {
            Company Company = CompanyService.GetCompanyByID(ID);
            return View(Company);
        }
    }
}