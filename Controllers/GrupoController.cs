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
     
        //Get cantidad de grupos del docente logeado
        public static int GetGruposByDocente(int idDocente,int noIconos)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand(@"select  count (*) from Grupos where idDocente=@idDocente", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@idDocente", idDocente);

                        command.ExecuteNonQuery();
                        noIconos =Convert.ToInt32(command.ExecuteScalar());
                        return noIconos;
                        /*using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                noIconos = dt.Rows.Count;
                                return noIconos;
                            }
                            command.ExecuteNonQuery();
                            connection.Close();

                        }*/
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        //Get nombres de grupos para los iconos, tomando en cuenta el docente logeado
        public static string GetNombreGrupo(int idDocente,int j)
        {
            string NombreGrupo;
            int idGrupo;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select idGrupo,nombreGrupo from Grupos where idDocente=@idDocente", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@idDocente", idDocente);
                        command.ExecuteNonQuery();
                        using(SQLiteDataAdapter adapter=new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            NombreGrupo = dt.Rows[j]["nombreGrupo"].ToString();
                            idGrupo = Convert.ToInt32(dt.Rows[j]["idGrupo"]);
                            return NombreGrupo;
                        }

                        
                    }
                           
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
        }

        //Get Id del grupo, esto es para que el icono generado para cada grupo tenga al Id enlazado
        public static int GetIdGrupo(int idDocente,int j)
        {
            int idGrupo;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("select idGrupo from Grupos where idDocente=@idDocente", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@idDocente", idDocente);
                        command.ExecuteNonQuery();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            idGrupo = Convert.ToInt32(dt.Rows[j]["idGrupo"]);
                            return idGrupo;
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
        }

        //Agregar nuevo grupo
        public bool Agregar(GrupoModel grupoModel)
        {
            try
            {
               using(SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command=new SQLiteCommand(@"INSERT INTO Grupos ('nombreGrupo','descGrupo','periodoGrupo','idDocente')
                    VALUES (@nombreGrupo,@descGrupo,@periodoGrupo,@idDocente)", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@nombreGrupo", grupoModel.Nombre);
                        command.Parameters.AddWithValue("@descGrupo", grupoModel.Descripcion);
                        command.Parameters.AddWithValue("@periodoGrupo", grupoModel.Periodo);
                        command.Parameters.AddWithValue("@idDocente", grupoModel.IdDocente);

                        var output=command.ExecuteNonQuery();
                        if (output == 1)
                        {
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
