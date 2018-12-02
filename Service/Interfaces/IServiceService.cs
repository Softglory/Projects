using Model;
using Model.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IServiceService
    {
        List<Model.Service> GetServices();
        IPagedList<ServiceViewModel> GetPagedServices(int page);
        Model.Service GetServiceByID(int ID);
        void CreateService(Model.Service Service);
        void EditService(Model.Service Service);
        void SaveService();
        Model.Service GetServiceByName(string ServiceName);
    }
}
