using Corvus_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Corvus_Proyecto.Dto;

namespace Corvus_Proyecto.Controllers
{
    public class DocenteController:BaseController
    {
      /*  public DocenteController(string connString)
        {
            _connString = connString;
        }*/

        //Login
        public bool Login(LoginDto dto)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select * from Docentes where nombreDocente=@nombreDocente AND passDocente=@passDocente ", connection))
                    {
                        command.Parameters.AddWithValue("@nombreDocente", dto.user);
                        command.Parameters.AddWithValue("@passDocente", dto.pass);

                        connection.Open();
                        using(SQLiteDataAdapter adapter=new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            command.ExecuteNonQuery();

                            if (dt.Rows.Count > 0)
                            {
                                return true;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return false;
        }

        public void Registar(LoginDto dto)
        {
            try
            {
                using(SQLiteConnection connection =new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using(SQLiteCommand command=new SQLiteCommand("insert into Docentes values nombreDocente, passDocente values (@nombreDocente,@passDocente)",
                        connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@nombreDocente", dto.user);
                        command.Parameters.AddWithValue("@passDocente", dto.pass);

                        command.ExecuteNonQuery();
                      
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
