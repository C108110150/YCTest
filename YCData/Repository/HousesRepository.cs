using Dapper;
using PSTFrame.Data;
using PSTFrame.Data.Dapper;
using YCData.Model.DB;

namespace YCData.Repository
{
        public class HousesRepository : DapperRepository<Houses, int>
        {
            public HousesRepository(IRepositoryContext context) : base(context)
            {

            }
        }

}
