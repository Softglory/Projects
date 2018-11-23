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
    public class AdService : IAdService
    {
        private readonly IAdRepository AdRepository;
        private readonly IUnitOfWork unitOfWork;

        public AdService(IAdRepository AdRepository, IUnitOfWork unitOfWork)
        {
            this.AdRepository = AdRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<Ad> GetAds()
        {
            List<Ad> Ads = AdRepository.GetAll().ToList();
            return Ads;
        }

        public Ad GetAdByID(int ID)
        {
            Ad Ad = AdRepository.GetByID(ID);
            return Ad;
        }

        public void CreateAd(Ad Ad)
        {
            Ad.CreatedOn = DateTime.Now;
            Ad.ModifiedOn = DateTime.Now;

            AdRepository.Add(Ad);
            SaveAd();
        }

        public void EditAd(Ad Ad)
        {
            Ad.ModifiedOn = DateTime.Now;
            AdRepository.Edit(Ad.AdId, Ad);
            SaveAd();
        }

        public void SaveAd()
        {
            unitOfWork.Commit();
        }


    }
}
