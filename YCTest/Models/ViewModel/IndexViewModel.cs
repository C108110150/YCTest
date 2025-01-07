using PSTFrame.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YCData.Model.DB;
using YCData.Model.View;

namespace YCTest.Models.ViewModel
{
    public class IndexViewModel: DataTablesParameters
    {
        public Houses  houses { get; set; } = new Houses();
        public List<V_Houses> DataList { get; set; } = new List<V_Houses>();

    }
}