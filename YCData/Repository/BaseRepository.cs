using Dapper;
using PSTFrame.Data;
using PSTFrame.Data.Dapper;
using System.Data.SqlClient;
using YCData.Helper;
using YCData.Model.DB;

namespace YCData.Repository
{
    public class BaseRepository<T> : DapperRepository<T, int> where T : class
    {
        public BaseRepository(IRepositoryContext context) : base(context)
        {

        }
        /// <summary>
        /// 預設資料庫連線字串
        /// </summary>
        public static string connStr = ConnectionString.YCDB;

        static BaseRepository()
        {
            //因透過Dapper Query時，未支援依Column轉換，故需增加以下Mapping
            PSTFrame.Data.Dapper.TypeMapper.TypeMapper.Initialize("KapDB.Model.DB");
        }

        public static DapperContext NewContext()
        {
            return new DapperContext(connStr);
        }


        public static SqlTransaction GetTransaction()
        {
            return PSTFrame.Data.Helepr.SQLHelper.GenerateSQLTransaction(connStr);
        }
        public static SqlConnection GetConnection()
        {
            return PSTFrame.Data.Helepr.SQLHelper.GenerateSQLConnection(connStr);
        }

        public static DapperContext GetContext()
        {

            return new DapperContext(connStr);
        }

    }
}