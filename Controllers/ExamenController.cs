using Corvus_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Controllers
{
    public class ExamenController : BaseController
    {

        //Get Examenes de un grupo determinado para llenar lista
        public static string GetExamenesByGrupo(int idGrupo)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand(@"select  nombreExamen from Examenes where idGrupo=@idGrupo", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@idGrupo", idGrupo);

                        command.ExecuteNonQuery();
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreExamen = reader.GetString("nombreExamen");
                                return nombreExamen;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return "";


        }
        //Get datos de examenes para el DataGrid
        public DataTable GetExamenes(int idGrupo)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select * from Examenes where idGrupo=@idGrupo", connection))
                    {
                        command.Parameters.AddWithValue("@idGrupo", idGrupo);
                        connection.Open();
                        command.ExecuteNonQuery();

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            return dt;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //Agregar nuevo examen a un grupo

        public bool Agregar(ExamenModel examenModel)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("insert into Examenes (nombreExamen,descExamen,UnidadExamen,fechaExamen,fechaLimiteExamen,idGrupo) " +
                        "values (@nombreExamen,@descExamen,@UnidadExamen,@fechaExamen,@fechaLimiteExamen,@idGrupo)" , connection))

                    {
                        command.Parameters.AddWithValue("@nombreExamen", examenModel.NombreActividad);
                        command.Parameters.AddWithValue("@descExamen", examenModel.DescActividad);
                        command.Parameters.AddWithValue("@UnidadExamen", examenModel.UnidadExamen);
                        command.Parameters.AddWithValue("@fechaExamen", examenModel.FechaActividad);
                        command.Parameters.AddWithValue("@fechaLimiteExamen", examenModel.FechaLimiteExamen);
                        command.Parameters.AddWithValue("@idGrupo", examenModel.IdGrupo);

                        connection.Open();

                        var output = command.ExecuteNonQuery();
                        if (output == 1)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
