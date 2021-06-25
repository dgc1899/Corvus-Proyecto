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

        //Login
        public bool Login(LoginDto dto)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand("select * from Docentes where idDocente=@idDocente AND passDocente=@passDocente", connection))
                    {
                        command.Parameters.AddWithValue("@idDocente", dto.IdDocente);
                        command.Parameters.AddWithValue("@passDocente", dto.pass);
                        using (SQLiteDataAdapter adapter=new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            command.ExecuteNonQuery();

                            if (dt.Rows.Count > 0)
                            {  
                                return true;
                            }
                            connection.Close();

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
     
     
        public bool Registar(LoginDto dto)
        {
            try
            {
                using(SQLiteConnection connection =new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command=new SQLiteCommand(@"INSERT INTO Docentes ('nombreDocente','passDocente') VALUES (@nombreDocente,@passDocente)",
                        connection))
                    {
                        // command.Parameters.Add(new SQLiteParameter("@nombreDocente", dto.user));
                        //command.Parameters.Add(new SQLiteParameter("@passDocente", dto.pass));
                        connection.Open();
                        command.Parameters.AddWithValue("@nombreDocente", dto.user);
                        command.Parameters.AddWithValue("@passDocente", dto.pass);

                       var output= command.ExecuteNonQuery();
                        if (output == 1)
                        {
                            connection.Close();

                            return true;
                        }
                        else
                            return false;
                    
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
