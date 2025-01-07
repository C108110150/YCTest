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
using YCData.Model.DB;
using YCData.Model.View;
using YCData.Repository;

namespace YCTest.Models.Service
{
    public class BaseApiService : QueryBaseService
    {
        HousesRepository  housesRepo;
        BaseRepository<V_Houses> V_housesRepo;

        public void init()
        {
            housesRepo = new HousesRepository(DbContext);
            V_housesRepo = new BaseRepository<V_Houses>(DbContext);
        }

        public BaseApiService()
        {
            init();
        }


        public IQueryable<V_Houses> GetHousesList(Houses model)
        {
            IQueryable<V_Houses> data;

            List<string> Where = new List<string>();
            if (!string.IsNullOrEmpty(model.HouseName))
            {
                Where.Add("HouseName Like '%@HouseName%'");
            }
            if (!string.IsNullOrEmpty(model.City))
            {
                Where.Add("City = @City");
            }
            if (!string.IsNullOrEmpty(model.Area))
            {
                Where.Add("Area = @Area");
            }
            if (!string.IsNullOrEmpty(model.Address))
            {
                Where.Add("Address = @Address");
            }
            string conditions = "";
            if (Where.Count > 0)
            {
                conditions = "WHERE " + string.Join(" AND ", Where);
            }
            data = V_housesRepo.GetList(conditions, model).AsQueryable();

            return data;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public MessageModel HousesInsert(Houses model)
        {
            MessageModel message = new MessageModel()
            {
                Status=true,
                Message="新增成功"
            };
            model.InsertDateTime = DateTime.Now;
            model.InsertUnitId = 1;
            model.InsertUserId = 1;
            model.UpdateDateTime = DateTime.Now;
            model.UpdateUnitId = 1;
            model.UpdateUserId = 1;
            try
            {
                DbContext.BeginTran();
                housesRepo.Insert(model);
                DbContext.Commit();
            }
            catch (Exception ex) 
            {
                DbContext.Rollback();
                message.Status = false;
                message.Message = ex.Message;
            }
            return message;
        }        
        /// <summary>
        /// 更增
        /// </summary>
        /// <returns></returns>
        public MessageModel HousesUpdate(Houses model)
        {
            MessageModel message = new MessageModel()
            {
                Status=true,
                Message="更新成功"
            };
            var data = housesRepo.Get(model.SerId);
            data.HouseName = model.HouseName;
            data.Area =model.Area;
            data.City =model.City;
            data.Address =model.Address;
            data.Phone =model.Phone;
            data.UpdateDateTime = DateTime.Now;
            data.UpdateUnitId = 1;
            data.UpdateUserId = 1;
            try
            {
                DbContext.BeginTran();
                housesRepo.Update(data);
                DbContext.Commit();
            }
            catch (Exception ex) 
            {
                DbContext.Rollback();
                message.Status = false;
                message.Message = ex.Message;
            }
            return message;
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <returns></returns>
        public MessageModel HousesDELETE(int Serid)
        {
            MessageModel message = new MessageModel()
            {
                Status = true,
                Message = "更新成功"
            };
            var model = housesRepo.Get(Serid);
            model.UpdateDateTime = DateTime.Now;
            model.UpdateUnitId = 1;
            model.UpdateUserId = 1;
            model.IsDelete = true;
            try
            {
                DbContext.BeginTran();
                housesRepo.Update(model);
                DbContext.Commit();
            }
            catch (Exception ex)
            {
                DbContext.Rollback();
                message.Status = false;
                message.Message = ex.Message;
            }
            return message;
        }
    }
}
