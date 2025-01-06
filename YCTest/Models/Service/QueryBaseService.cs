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

namespace YCTest.Models.Service
{
    public class QueryBaseService : BaseService
    {
        protected Logger logger = LogManager.GetCurrentClassLogger();
        public QueryBaseService(IRepositoryContext dbcontext) : base(dbcontext)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectKey">WebConfig ConnectString Name</param>
        public QueryBaseService(string connectKey = "manage") : base(System.Configuration.ConfigurationManager.ConnectionStrings[connectKey].ToString())
        {

        }

    }
}
