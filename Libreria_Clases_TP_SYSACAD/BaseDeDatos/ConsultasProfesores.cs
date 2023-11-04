using Libreria_Clases_TP_SYSACAD.Entidades_Primarias;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasProfesores : ConexionBD
    {
        private static List<Profesor> _listaProfesores = new List<Profesor>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE PROFESORES A PARTIR DE BD

        private static List<string> DevolverCursosDeProfesor(string correo)
        {
            List<string> listaCursosProfesor = new List<string>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT codigoCurso FROM ProfesoresEnCursos WHERE correoProfesor = @correo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@correo", correo);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string codigoCurso = readerAlternativo["codigoCurso"].ToString();
                                listaCursosProfesor.Add(codigoCurso);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaCursosProfesor;
        }

        internal static void CrearInstanciasDeProfesoresAPartirDeBD()
        {
            _listaProfesores.Clear();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM Profesores";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string direccion = reader["direccion"].ToString();
                        string telefono = reader["telefono"].ToString();
                        string correo = reader["correo"].ToString();
                        string especializacion = reader["especializacion"].ToString();

                        List<string> _codigosCursosDeProfesor = DevolverCursosDeProfesor(correo);

                        Profesor profesorReconstruido = new Profesor(nombre, direccion, telefono, correo, especializacion, _codigosCursosDeProfesor);

                        _listaProfesores.Add(profesorReconstruido);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }

        ///////////////////////CREATE
        internal static void IngresarNuevoProfesor(Profesor profesorNuevo)
        {
            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO Profesores (nombre, direccion, telefono, correo, especializacion) " +
                                      "VALUES (@nombre, @direccion, @telefono, @correo, @especializacion)";

                command.Parameters.AddWithValue("@nombre", profesorNuevo.Nombre);
                command.Parameters.AddWithValue("@direccion", profesorNuevo.Direccion);
                command.Parameters.AddWithValue("@telefono", profesorNuevo.Telefono);
                command.Parameters.AddWithValue("@correo", profesorNuevo.Correo);
                command.Parameters.AddWithValue("@especializacion", profesorNuevo.Especializacion);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////READ

        internal static bool BuscarProfesorExistenteBD(string correo)
        {
            bool resultadoBusqueda = false;

            foreach (Profesor profesor in _listaProfesores)
            {
                if (profesor.Correo == correo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        ///////////////////////UPDATE

        public static void EditarProfesor(string correo, string direccion, string especializacion, string nombre, string telefono, string correoOriginal)
        {
            try
            {
                connection.Open();

                command.CommandText = "UPDATE Profesores SET nombre = @nombre, direccion = @direccion, telefono = @telefono, correo = @correo, especializacion = @especializacion WHERE correo = @correoOriginal";

                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@especializacion", especializacion);
                command.Parameters.AddWithValue("@correoOriginal", correoOriginal);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        public static void AgregarCursoAProfesor(string correoProfesor, string codigoCurso)
        {
            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO ProfesoresEnCursos (correoProfesor, codigoCurso) " +
                                      "VALUES (@correo, @codigo)";

                command.Parameters.AddWithValue("@correo", correoProfesor);
                command.Parameters.AddWithValue("@codigo", codigoCurso);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        ///////////////////////DELETE

        public static void EliminarProfesorBD(string correo)
        {
            try
            {
                connection.Open();

                command.CommandText = @"DELETE FROM Profesores WHERE correo = @correo";

                command.Parameters.AddWithValue("@correo", correo);

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            CrearInstanciasDeProfesoresAPartirDeBD();
        }

        //Getters y setters
        public static List<Profesor> Profesores { get { return _listaProfesores; } }
    }
}
