using PSTFrame.MVC;
using PSTFrame.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using YCData.Model.DB;
using YCData.Model.View;
using YCTest.Models.Service;
using YCTest.Models.ViewModel;

namespace YCTest.Controllers
{
    public class BaseApiController : BaseController
    {

        [HttpPost]
        //[Route("api/BaseApi/GetHouses")]
        public JsonResult GetHouses(IndexViewModel source)
        {
            BaseApiService service = new BaseApiService();
            IQueryable<V_Houses> data = service.GetHousesList(source.houses);
            IndexViewModel model = new IndexViewModel();
            model = source;
            model.TotalCount = data.Count();
            data = data.Skip(source.Start).Take(source.Length);
            model.DataList = data.ToList();
            return DataTablesJson(model.Draw, model.TotalCount, model.TotalCount, model.DataList, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult POSTHouses(IndexViewModel source)
        {
            BaseApiService service = new BaseApiService();

            var message = service.HousesInsert(source.houses);
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult PUTHouses(IndexViewModel source)
        {
            BaseApiService service = new BaseApiService();
            var message = service.HousesUpdate(source.houses);
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DELETEHouses(int Serid)
        {
            BaseApiService service = new BaseApiService();
            var message = service.HousesDELETE(Serid);
            return Json(message, JsonRequestBehavior.AllowGet);
        }

    }
}