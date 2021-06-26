using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corvus_Proyecto.Model;
using Corvus_Proyecto.Models;

namespace Corvus_Proyecto.Controllers
{
    public class ActividadController:BaseController
    {
        //Get Actividades de un grupo determinado para llenar lista
       public static DataTable GetActividadesByGrupo(int idGrupo)
        {
            try
              {
                 using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                  {
                     using (SQLiteCommand command = new SQLiteCommand(@"select  nombreActividad from Actividades where idGrupo=@idGrupo", connection))
                        {
                          connection.Open();
                          command.Parameters.AddWithValue("@idGrupo", idGrupo);

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

        //Get datos de actividades para el DataGrid
        public  DataTable GetActividades(int idGrupo)
        {
            try
            {
                using(SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select * from Actividades where idGrupo=@idGrupo", connection))
                    {
                        command.Parameters.AddWithValue("@idGrupo", idGrupo);
                        connection.Open();
                        command.ExecuteNonQuery();

                        using(SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            return dt;

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //Agregar nueva actividad a un grupo

        public bool Agregar(ActividadModel actividadModel)
        {
            try
            {
                using(SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using(SQLiteCommand command = new SQLiteCommand("insert into Actividades (nombreActividad,fechaActividad,descActividad,idGrupo)" +
                        "values (@nombreActividad,@fechaActividad,@descActividad,@idGrupo)", connection))
                    {
                        command.Parameters.AddWithValue("@nombreActividad", actividadModel.NombreActividad);
                        command.Parameters.AddWithValue("@fechaActividad", actividadModel.FechaActividad);
                        command.Parameters.AddWithValue("@descActividad", actividadModel.DescActividad);
                        command.Parameters.AddWithValue("@idGrupo", actividadModel.IdGrupo);

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
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }

}
