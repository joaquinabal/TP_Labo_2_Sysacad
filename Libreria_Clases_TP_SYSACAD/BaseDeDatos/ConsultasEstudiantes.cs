using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasEstudiantes : ConexionBD
    {
        internal static void IngresarUsuarioBD(Estudiante nuevoEstudiante)
        {
            try
            {
                using (connection)
                {
                    Guid nuevoGuid = Guid.NewGuid();
                    nuevoEstudiante.IdentificadorUnico = nuevoGuid;
                    nuevoEstudiante.Contrasenia = Hash.HashPassword(nuevoEstudiante.Contrasenia);

                    // Secuencia INSERT
                    command.CommandText = "INSERT INTO Estudiante (legajo, nombre, direccion, numeroTelefono, correo, contrasenia, identificadorUnico, debeCambiarContrasenia, creditos, promedio) " +
                                          "VALUES (@legajoEstudiante, @nombreEstudiante, @direccionEstudiante, @telefonoEstudiante, @correoEstudiante, @contraseniaEstudiante, @identifiadorUnicoEstudiante, @debeCambiarContraseniaEstudiante, @creditosEstudiante, @promedioEstudiante)";

                    // Borrar cualquier parámetro existente en el comando.
                    command.Parameters.Clear();

                    // Agrego los parametros
                    command.Parameters.AddWithValue("@legajoEstudiante", nuevoEstudiante.Legajo);
                    command.Parameters.AddWithValue("@nombreEstudiante", nuevoEstudiante.Nombre);
                    command.Parameters.AddWithValue("@direccionEstudiante", nuevoEstudiante.Direccion);
                    command.Parameters.AddWithValue("@telefonoEstudiante", nuevoEstudiante.NumeroTelefono);
                    command.Parameters.AddWithValue("@correoEstudiante", nuevoEstudiante.Correo);
                    command.Parameters.AddWithValue("@contraseniaEstudiante", nuevoEstudiante.Contrasenia);
                    command.Parameters.AddWithValue("@identifiadorUnicoEstudiante", nuevoEstudiante.IdentificadorUnico);
                    command.Parameters.AddWithValue("@debeCambiarContraseniaEstudiante", nuevoEstudiante.DebeCambiarContrasenia);
                    command.Parameters.AddWithValue("@creditosEstudiante", nuevoEstudiante.Creditos);
                    command.Parameters.AddWithValue("@promedioEstudiante", nuevoEstudiante.Promedio);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
        }

        ///////////////////////READ

        internal static bool BuscarUsuarioCredencialesBD(string correo, string contrasenia)
        {
            try
            {
                command.CommandText = "SELECT * FROM Estudiante WHERE correo = @correo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@correo", correo);

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string contraseniaEnBD = reader["contrasenia"].ToString();
                    bool comparacionContrasenias = Hash.VerifyPassword(contrasenia, contraseniaEnBD);

                    if (comparacionContrasenias)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        internal static bool BuscarUsuarioExistenteBD(string correo, string legajo)
        {
            try
            {
                command.CommandText = "SELECT * FROM Estudiante WHERE correo = @correo or legajo = @legajo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@legajo", legajo);

                connection.Open();
                reader = command.ExecuteReader();

                bool tieneFilas = reader.HasRows;

                return tieneFilas;  // Retorna true si se encontraron filas, de lo contrario, retorna false
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static bool BuscarSiUsuarioDebeCambiarContrasenia(string correo)
        {
            try
            {
                command.CommandText = "SELECT * FROM Estudiante WHERE correo = @correo";

                // Borrar cualquier parámetro existente en el comando.
                command.Parameters.Clear();

                // Agregar el nuevo parámetro.
                command.Parameters.AddWithValue("@correo", correo);

                connection.Open();
                reader = command.ExecuteReader();

                bool debeCambiarContrasenia = false;

                while (reader.Read())
                {
                    debeCambiarContrasenia = Convert.ToBoolean(reader["debeCambiarContrasenia"]);
                }

                return debeCambiarContrasenia;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // TERMINAR UNA VEZ RECONSTRUIDO CURSOS
        //public Estudiante ObtenerEstudianteSegunLegajo(string legajo)
        //{
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM Estudiante WHERE legajo = @legajo";

        //        // Borrar cualquier parámetro existente en el comando.
        //        command.Parameters.Clear();

        //        // Agregar el nuevo parámetro.
        //        command.Parameters.AddWithValue("@legajo", legajo);

        //        connection.Open();
        //        reader = command.ExecuteReader();

        //        Estudiante estudianteADevolver = null;

        //        while (reader.Read())
        //        {

        //            string nombre = reader["nombre"].ToString();
        //            string legajoEstudiante = reader["legajo"].ToString();
        //            string direccion = reader["direccion"].ToString();
        //            string numeroTelefono = reader["numeroTelefono"].ToString();
        //            string correo = reader["correo"].ToString();
        //            string contrasenia = reader["contrasenia"].ToString();
        //            bool _debeCambiarContrasenia = Convert.ToBoolean(reader["debeCambiarContrasenia"]);
        //            List<Curso> _cursosInscriptos;
        //            List<ConceptoDePago> _conceptosAPagar = new List<ConceptoDePago>();
        //            List<string> _codigosDeFamiliaDeCursosCompletados = new List<string>();
        //            int _creditos;
        //            double _promedio;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        // TERMINAR UNA VEZ RECONSTRUIDO CURSOS
        //public static List<Curso> ObtenerCursosPertenecientesAlEstudiante(string legajo)
        //{
        //    try
        //    {
        //        command.CommandText = "SELECT * FROM Estudiante WHERE legajo = @legajo";

        //        // Borrar cualquier parámetro existente en el comando.
        //        command.Parameters.Clear();

        //        // Agregar el nuevo parámetro.
        //        command.Parameters.AddWithValue("@legajo", legajo);

        //        connection.Open();
        //        reader = command.ExecuteReader();

        //        List<Curso> listaCursosDelEstudiante = new List<Curso>();

        //        while (reader.Read())
        //        {

        //            string nombre = reader["nombre"].ToString();
        //            string legajoEstudiante = reader["legajo"].ToString();
        //            string direccion = reader["direccion"].ToString();
        //            string numeroTelefono = reader["numeroTelefono"].ToString();
        //            string correo = reader["correo"].ToString();
        //            string contrasenia = reader["contrasenia"].ToString();
        //            bool _debeCambiarContrasenia = Convert.ToBoolean(reader["debeCambiarContrasenia"]);
        //            List<Curso> _cursosInscriptos;
        //            List<ConceptoDePago> _conceptosAPagar = new List<ConceptoDePago>();
        //            List<string> _codigosDeFamiliaDeCursosCompletados = new List<string>();
        //            int _creditos;
        //            double _promedio;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        ///////////////////////UPDATE


        // TERMINAR UNA VEZ RECONSTRUIDO CURSOS
        //internal void AgregarCursoAEstudiante(Estudiante estudianteQueSeInscribe, Curso curso)
        //{
        //    foreach (Estudiante estudiante in listaEstudiante)
        //    {
        //        if (estudiante.IdentificadorUnico == estudianteQueSeInscribe.IdentificadorUnico)
        //        {
        //            estudiante.CursosInscriptos.Add(curso);
        //        }
        //    }
        //    ArchivosJsonEstudiantes.GuardarArchivoJSON(listaEstudiante);
        //}


        public static void CambiarContraseñaAEstudiante(string correo, string nuevaContrasenia)
        {
            try
            {
                string nuevaContraseniaHasheada = Hash.HashPassword(nuevaContrasenia);

                using (connection)
                {
                    // Secuencia INSERT
                    command.CommandText = "UPDATE Estudiante SET contrasenia = @nuevaContraseniaHasheada, debeCambiarContrasenia = 'False' WHERE correo = @correo";

                    // Borrar cualquier parámetro existente en el comando.
                    command.Parameters.Clear();

                    // Agrego los parametros
                    command.Parameters.AddWithValue("@nuevaContraseniaHasheada", nuevaContraseniaHasheada);
                    command.Parameters.AddWithValue("@correo", correo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
        }

        //AGREGAR REFERENCIA UNA VEZ SOLUCIONADO LOS BUGS
        internal void EliminarCursoATodosLosEstudiantes(string codigo)
        {
            try
            {
                using (connection)
                {
                    // Secuencia DELETE
                    command.CommandText = "DELETE FROM RegistroInscripcion WHERE codigoCurso = @codigo";

                    // Borrar cualquier parámetro existente en el comando.
                    command.Parameters.Clear();

                    // Agrego los parametros
                    command.Parameters.AddWithValue("@codigo", codigo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
        }

        //Getters y setters
        //public List<Estudiante> Estudiantes { get { return listaEstudiante; } }
    }
}
