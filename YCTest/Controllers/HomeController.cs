using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YCTest.Models.Service;

namespace YCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index00()
        {
            HomeService service = new HomeService();
            ViewBag.CityOptions = service.GetCityOptions();
            ViewBag.AreaOptions = service.GetAreaOptions();
            return View();
        }
    }
}