using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus_Proyecto.Model;
using System.Data.SQLite;
using Dapper;
using System.Data;

namespace Corvus_Proyecto.Controllers
{
    public class GrupoController : BaseController
    {
        public GrupoController(string connString)
        {
            _connString = connString;
        }

        //Agregar nuevo grupo
        public void Agregar(GrupoModel grupoModel)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    cnn.Execute("insert into Grupos(nombreGrupo,periodoGrupo,descGrupo) values(@nombreGrupo,@periodoGrupo,descGrupo)",grupoModel);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
