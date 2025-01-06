using NLog;
using PSTFrame.Data;
using PSTFrame.Data.Dapper;
using PSTFrame.MVC;
using PSTFrame.MVC.Gear;
using PSTFrame.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using YCData.Repository;

namespace YCTest.Models.Service
{
    public class HomeService : QueryBaseService
    {
        HousesRepository  housesRepo;

        public void init()
        {
            housesRepo = new HousesRepository(DbContext);
        }

        public HomeService()
        {
            init();
        }

        public object GetCityOptions(string defaultValue = "")
        {
            return this.GenSelectItem(DbContext, "CodeTable", "CodeText", "CodeText", SelectOption.All, new string[1] { "IsDelete = 0 AND Codetype='City'" }, defaultValue: defaultValue);
        }        
        public object GetAreaOptions(string defaultValue = "")
        {
            return this.GenSelectItem(DbContext, "CodeTable", "CodeText", "CodeText", SelectOption.All, new string[1] { "IsDelete = 0 AND Codetype='Area'" }, defaultValue: defaultValue);
        }
    }
}
