using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DB;

namespace TrackerLibrary
{
   public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }

        public static void InitializeConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO- do  something
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            if (db == DatabaseType.textFile)
            {
                //TODO - do something
                TextConnection text = new TextConnection();
                Connection = text;
            }
        }

        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
