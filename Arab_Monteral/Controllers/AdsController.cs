using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.ViewModels;
using System.IO;
using PagedList;

namespace Arab_Monteral.Controllers
{
    public class AdsController : Controller
    {
        private readonly IAdService AdService;
        public AdsController(IAdService adService)
        {
            this.AdService = adService;
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index(int? page)
        {

            IPagedList<AdViewModel> PagedAccounts = AdService.PagedAds(page ?? 1);
            return View(PagedAccounts);
        }

        // GET: Ads
        [Authorize(Roles = "Admin")]
        public ActionResult AdsAdmin(int?ID)
        {
            List<string> Carrers = new List<string>();
            Carrers.Add("محاسبة");
            Carrers.Add("محاماة");
            Carrers.Add("بنوك");
            Carrers.Add("تعليم");
            Carrers.Add("مفروشات");
            Carrers.Add("خدمات تأمين");
            Carrers.Add("خياطة");
            Carrers.Add("سياحة");
            Carrers.Add("تجارة");
            Carrers.Add("طب");
            ViewBag.CarrersList = new SelectList(Carrers);

            if (ID != null) //edit
            {
                Ad Ad = AdService.GetAdByID(ID ?? 0);
                AdViewModel AdView = new AdViewModel()
                {
                    AdId = Ad.AdId,
                    AdDescription = Ad.AdDescription,
                    AdType = Ad.AdType,
                    AdImage = Ad.AdImage,
                    AdCarrer = Ad.AdCarrer,
                    CreatedOn = Ad.CreatedOn,
                    ModifiedOn = Ad.ModifiedOn
                };
                return View(AdView);
            }

            return View("AdsAdmin");
        }

        [HttpPost]
        public ActionResult AdsAdmin(AdViewModel AdView, int? ID, HttpPostedFileBase file)
        {
            List<string> Carrers = new List<string>();
            Carrers.Add("محاسبة");
            Carrers.Add("محاماة");
            Carrers.Add("بنوك");
            Carrers.Add("تعليم");
            Carrers.Add("مفروشات");
            Carrers.Add("خدمات تأمين");
            Carrers.Add("خياطة");
            Carrers.Add("سياحة");
            Carrers.Add("تجارة");
            Carrers.Add("طب");
            ViewBag.CarrersList = new SelectList(Carrers);


            if (ID == null)
            {
                AdView.CreatedOn = DateTime.Now;
            }

            AdView.ModifiedOn = DateTime.Now;
            ModelState.Clear();
            TryValidateModel(AdView);

            if (ModelState.IsValid)
            {
                //upload File
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads/Ads"), fileName);
                    file.SaveAs(path);

                    fileName = Path.GetFileName(path);
                    AdView.AdImage = "Uploads/Ads/" + fileName;
                }

                Ad Ad = new Ad()
                {
                    AdId = AdView.AdId,
                    AdImage = AdView.AdImage,
                    AdDescription = AdView.AdDescription,
                    AdType = AdView.AdType,
                    AdCarrer = AdView.AdCarrer,
                    CreatedOn = AdView.CreatedOn,
                    ModifiedOn = AdView.ModifiedOn
                };

                if (ID == null) //add
                {
                    AdService.CreateAd(Ad);
                }
                else //update
                {
                    Ad.AdId = ID ?? 0;
                    AdService.EditAd(Ad);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(AdView);
        }
    }
}