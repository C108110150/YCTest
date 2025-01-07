using PSTFrame.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YCData.Model.View;
using YCTest.Models.Service;
using YCTest.Models.ViewModel;

namespace YCTest.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index00()
        {
            IndexViewModel  model= new IndexViewModel();
            HomeService service = new HomeService();
            ViewBag.CityOptions = service.GetCityOptions();
            ViewBag.AreaOptions = service.GetAreaOptions();
            return View(model);
        }


        public ActionResult IndexA00()
        {
            IndexViewModel model = new IndexViewModel();
            HomeService service = new HomeService();
            ViewBag.CityOptions = service.GetCityOptions();
            ViewBag.AreaOptions = service.GetAreaOptions();
            return View(model);
        }


        public ActionResult IndexE00(int SerId)
        {
            IndexViewModel model = new IndexViewModel();
            HomeService service = new HomeService();
            model.houses= service.GetHouses(SerId);
            ViewBag.CityOptions = service.GetCityOptions();
            ViewBag.AreaOptions = service.GetAreaOptions();
            return View(model);
        }

    }
}