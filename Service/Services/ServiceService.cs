using Data.Infrastructure;
using Data.Repositories;
using Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ViewModels;

namespace Service
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository ServiceRepository;
        private readonly IUnitOfWork unitOfWork;

        public ServiceService(IServiceRepository ServiceRepository, IUnitOfWork unitOfWork)
        {
            this.ServiceRepository = ServiceRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<Model.Service> GetServices()
        {
            List<Model.Service> Services = ServiceRepository.GetAll().ToList();
            return Services;
        }
        public IPagedList<ServiceViewModel> GetPagedServices(int page)
        {
            List<Model.Service> AllServices = ServiceRepository.GetAll().ToList();

            List<ServiceViewModel> ServicesView = new List<ServiceViewModel>();
            foreach (Model.Service serv in AllServices)
            {
                ServiceViewModel AccView = new ServiceViewModel()
                {
                    ServiceId = serv.ServiceId,
                    ServiceName = serv.ServiceName,
                    Status = serv.Status,
                    CreatedOn = serv.CreatedOn,
                    ModifiedOn = serv.ModifiedOn
                };
                ServicesView.Add(AccView);
            }

            int PageSize = 5;
            IPagedList<ServiceViewModel> PagedResults = ServicesView.ToPagedList(page, PageSize);//paging 
            return PagedResults;
        }

        public Model.Service GetServiceByID(int ID)
        {
            Model.Service Service = ServiceRepository.GetByID(ID);
            return Service;
        }

        public void CreateService(Model.Service Service)
        {
            ServiceRepository.Add(Service);
            SaveService();
        }

        public void EditService(Model.Service Service)
        {
            ServiceRepository.Edit(Service.ServiceId, Service);
            SaveService();
        }

        public void SaveService()
        {
            unitOfWork.Commit();
        }

        public Model.Service GetServiceByName(string ServiceName)
        {
            Model.Service Service = ServiceRepository.Get(x => x.ServiceName == ServiceName && x.Status == true).FirstOrDefault();
            return Service;
        }


    }
}
