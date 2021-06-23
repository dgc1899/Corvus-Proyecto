using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace Corvus_Proyecto
{
   public  class SqliteDataAccess
    {

       public static string  GetConnectionString(string id="connString")
        {
 
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    
    }
}
