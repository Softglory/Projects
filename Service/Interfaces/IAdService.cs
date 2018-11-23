using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IAdService
    {
        List<Ad> GetAds();
        Ad GetAdByID(int ID);
        void CreateAd(Ad Ad);
        void EditAd(Ad Ad);
        void SaveAd();
    }
}
