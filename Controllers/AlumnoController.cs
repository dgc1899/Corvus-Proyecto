using Corvus_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Corvus_Proyecto.Models;

namespace Corvus_Proyecto.Controllers
{
    public class AlumnoController : BaseController
    {
        //Metodo para conseguir todos los alumnos, para ponerlos en el listview
        public DataTable GetAlumnos(int idGrupo)
        {
            using(SQLiteConnection connection=new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
            {
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand("select Alumnos.noControl,Alumnos.nombreAlumno,Alumnos.apPatAlumno, Alumnos.apMatAlumno from Alumnos" +
                        " Inner Join Grupo_has_Alumnos on Alumnos.noControl = Grupo_has_Alumnos.noControl " +
                        "Inner Join Grupos on Grupos.idGrupo = Grupo_has_Alumnos.idGrupo where Grupos.idGrupo =@idGrupo", connection))
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
                catch(Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
               
            }
        }

        //Método para agregar alumnos a la tabla Alumnos
        public int Agregar(AlumnoModel alumnoModel)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {

                    using (SQLiteCommand command = new SQLiteCommand("insert into Alumnos (nombreAlumno,apPatAlumno,apMatAlumno,correoAlumno)" +
                   " values (@nombreAlumno,@apPatAlumno,@apMatAlumno,@correoAlumno)", connection))
                    {
                        command.Parameters.AddWithValue("@nombreAlumno", alumnoModel.Nombre);
                        command.Parameters.AddWithValue("@apPatAlumno", alumnoModel.ApPaterno);
                        command.Parameters.AddWithValue("@apMatAlumno", alumnoModel.ApMaterno);
                        command.Parameters.AddWithValue("@correoAlumno", alumnoModel.CorreoAlumno);

                        connection.Open();
                        command.ExecuteNonQuery(); 
                        
                        //Conseguir el numero de control del alumno que se acaba de insertar, para poder usarlo en el siguiente metodo
                        using(SQLiteCommand command1 = new SQLiteCommand("select seq from sqlite_sequence where name='Alumnos' ",connection))
                        {
                            int noControl = Convert.ToInt32(command1.ExecuteScalar());
                            if (noControl != 0)
                            {
                                return noControl;
                            }
                            else
                                return 0;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }
    

        //Agregar al alumno al grupo desde el cual se le añadio
        public bool AgregarAlGrupo(int noControl,int idGrupo)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using (SQLiteCommand command = new SQLiteCommand("insert into Grupo_has_Alumnos (noControl,idGrupo) values" +
                               "(@noControl,@idGrupo)", connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("noControl", noControl);
                        command.Parameters.AddWithValue("idGrupo", idGrupo);

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
            catch (Exception ex)
            {

                throw new Exception(ex.Message,ex);
            }
           
            
        }

        //Eliminar un alumno de Grupo_has_Alumnos, con tal de eliminar el constrain de la fk
        public bool EliminarDeGrupo(AlumnoModel alumnoModel)
        {
            try
            {
                using(SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
                {
                    using(SQLiteCommand command = new SQLiteCommand("delete from Grupo_has_Alumnos where noControl=@noControl",connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@noControl", alumnoModel.NoControl);
                       var output= command.ExecuteNonQuery();
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

        //ELiminar al alumno de la tabla Alumnos
        public bool Eliminar(AlumnoModel alumnoModel)
        {
            using(SQLiteConnection connection=new SQLiteConnection(SqliteDataAccess.GetConnectionString()))
            {
                using(SQLiteCommand command= new SQLiteCommand("delete from Alumnos where noControl=@noControl",connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@noControl", alumnoModel.NoControl);
                    var output=command.ExecuteNonQuery();
                    if (output == 1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
