using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DB
{
    public class SQLConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnectionString("DB")))
            {
                var p = new DynamicParameters();
                p.Add("@placeNum", model.PlaceNum);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@prizeAmount", model.PrizeAmount);
                p.Add("@prizePercent", model.PrizePercentage);
                p.Add("@id",0, dbType: DbType.Int32,direction: ParameterDirection.Output);

                connection.Execute("spPrizes_insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");

                return model;


            }
        }
    }
}
