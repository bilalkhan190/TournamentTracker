using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DB;

namespace TrackerLibrary
{
   public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool database, bool textFile)
        {
            if (database)
            {
                //TODO- do  something
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                //TODO - do something
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
