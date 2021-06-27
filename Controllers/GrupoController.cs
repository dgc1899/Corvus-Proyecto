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

        //Get información de un grupo para poblar textboxes
        public GrupoModel GetGrupos(int idGrupo)
        {
            try
            {
                using(SQLiteConnection connection=new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using(SQLiteCommand command=new SQLiteCommand("select nombreGrupo,descGrupo,periodoGrupo from Grupos where idGrupo=@idGrupo", connection))
                    {
                        command.Parameters.AddWithValue("@idGrupo", idGrupo);
                        connection.Open();
                        command.ExecuteNonQuery();

                        using(SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            GrupoModel grupoModel = new GrupoModel();
                            grupoModel.Nombre = dt.Rows[0]["nombreGrupo"].ToString();
                            grupoModel.Descripcion = dt.Rows[0]["descGrupo"].ToString();
                            grupoModel.Periodo = dt.Rows[0]["periodoGrupo"].ToString();

                            return grupoModel;
                        }
                    }
                }
            }
            catch(Exception ex)
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

        //Modificar grupo
        public bool Modificar(GrupoModel grupoModel)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("UPDATE Grupos Set nombreGrupo=@nombreGrupo,descGrupo=@descGrupo,periodoGrupo=@periodoGrupo where idGrupo=@idGrupo", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@idGrupo", grupoModel.IdGrupo);
                        command.Parameters.AddWithValue("@nombreGrupo", grupoModel.Nombre);
                        command.Parameters.AddWithValue("@descGrupo", grupoModel.Descripcion);
                        command.Parameters.AddWithValue("@periodoGrupo", grupoModel.Periodo);

                        var output = command.ExecuteNonQuery();
                        if (output == 1)
                        {
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

        //Eliminar grupo
        public void Eliminar(GrupoModel grupoModel)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    SQLiteTransaction transaction;

                    connection.Open();
                    transaction = connection.BeginTransaction();
                    try
                    {
                        //Poner todos los commands dentro de este bloque try
                        using (SQLiteCommand command = new SQLiteCommand("delete from Grupo_has_Alumnos where idGrupo=@idGrupo",connection,transaction))
                        {
                            command.Parameters.AddWithValue("@idGrupo", grupoModel.IdGrupo);
                           var output= command.ExecuteNonQuery();
                            /*if (output == 1)
                            {
                                using (SQLiteCommand command1 = new SQLiteCommand("delete from Alumnos where noControl=@noControl", connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@noControl",);
                                    command.ExecuteNonQuery();
                                }
                            }*/
                        }

                        using (SQLiteCommand command = new SQLiteCommand("delete from Actividades where idGrupo=@idGrupo", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idGrupo", grupoModel.IdGrupo);
                            command.ExecuteNonQuery();
                        }

                        using (SQLiteCommand command = new SQLiteCommand("delete from Examenes where idGrupo=@idGrupo", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idGrupo", grupoModel.IdGrupo);
                            command.ExecuteNonQuery();
                        }

                        using (SQLiteCommand command = new SQLiteCommand("delete from Grupos where idGrupo=@idGrupo", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idGrupo", grupoModel.IdGrupo);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch(SQLiteException sqlerror)
                    {
                        transaction.Rollback();
                        throw new SQLiteException(sqlerror.Message, sqlerror);
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
