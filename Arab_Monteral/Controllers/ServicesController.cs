using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.ViewModels;
using PagedList;
using Service;

namespace Arab_Monteral.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService ServiceService;
        public ServicesController(IServiceService ServiceService)
        {
            this.ServiceService = ServiceService;
        }
        // GET: Services
        [Authorize(Roles = "Admin")]
        public ActionResult Index(int?page)
        {
            IPagedList<ServiceViewModel> PagedServices = ServiceService.GetPagedServices(page ?? 1);
            return View(PagedServices);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Create(int? ID)
        {
            if (ID != null) //edit
            {
                Model.Service Serv = ServiceService.GetServiceByID(ID ?? 0);

                ServiceViewModel ServView = new ServiceViewModel()
                {
                    ServiceId = Serv.ServiceId,
                    ServiceName = Serv.ServiceName,
                    Status = Serv.Status,
                    CreatedOn = Serv.CreatedOn,
                    ModifiedOn = Serv.ModifiedOn
                };
                return View(ServView);
            }
            return View(new ServiceViewModel());
        }

        // POST: Service/Create/ID
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(ServiceViewModel ServiceView, int? ID, HttpPostedFileBase file)
        {
            if (ID == null)
            {
                ServiceView.CreatedOn = DateTime.Now;
            }

            ServiceView.ModifiedOn = DateTime.Now;
            ModelState.Clear();
            TryValidateModel(ServiceView);

            if (ModelState.IsValid)
            {

                Model.Service Serv = new Model.Service()
                {
                    ServiceId = ServiceView.ServiceId,
                    ServiceName = ServiceView.ServiceName,
                    Status = ServiceView.Status,
                    CreatedOn = ServiceView.CreatedOn,
                    ModifiedOn = ServiceView.ModifiedOn
                };

                if (ID == null) //add
                {
                    ServiceService.CreateService(Serv);
                    Serv = ServiceService.GetServiceByName(Serv.ServiceName);
                }
                else //update
                {
                    Serv.ServiceId = ID ?? 0;
                    ServiceService.EditService(Serv);
                }

                return Redirect("~/Services/Details/" + Serv.ServiceId);
            }

            return View(ServiceView);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(int ID)
        {
            Model.Service Serv = ServiceService.GetServiceByID(ID);
            ServiceViewModel ServView = new ServiceViewModel()
            {
                ServiceId = Serv.ServiceId,
                ServiceName = Serv.ServiceName,
                Status = Serv.Status,
                CreatedOn = Serv.CreatedOn,
                ModifiedOn = Serv.ModifiedOn,
            };
            return View(ServView);

        }

    }
}