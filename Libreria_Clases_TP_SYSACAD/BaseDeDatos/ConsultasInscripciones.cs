using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasInscripciones : ConexionBD
    {
        private static List<RegistroDeInscripcion> _listaRegistrosInscripcion = new List<RegistroDeInscripcion>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE INSCRIPCIONES A PARTIR DE BD
        internal static string ObtenerNombreAlumnoDesdeLegajo(string legajo)
        {
            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT nombre FROM Estudiante WHERE legajo = @legajo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@legajo", legajo);

                    try
                    {
                        connectionAlternativa.Open();

                        string nombreAlumno = "";

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                nombreAlumno = readerAlternativo["nombre"].ToString();
                            }
                        }

                        return nombreAlumno;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private static string ObtenerNombreCursoDesdeCodigo(string codigo)
        {
            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT nombre FROM Curso WHERE codigo = @codigo", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@codigo", codigo);

                    try
                    {
                        connectionAlternativa.Open();

                        string nombreCurso = "";

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                nombreCurso = readerAlternativo["nombre"].ToString();
                            }
                        }

                        return nombreCurso;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }
        }

        internal static Carrera DevolverCarreraDedeCodigoCurso(string codigoCurso)
        {
            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestSYSACAD; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand("SELECT carreraCodigo FROM Curso WHERE codigo = @codigoCurso", connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@codigoCurso", codigoCurso);

                    try
                    {
                        connectionAlternativa.Open();

                        string carrera = "";

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                carrera = readerAlternativo["carreraCodigo"].ToString();
                            }
                        }

                        return (Carrera)Enum.Parse(typeof(Carrera), carrera);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }
        }

        internal static void CrearInstanciasDeInscripcionesAPartirDeBD()
        {
            _listaRegistrosInscripcion.Clear();

            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM RegistroInscripcion";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string legajo = reader["legajo"].ToString();
                        string codigoCurso = reader["codigoCurso"].ToString();
                        DateTime fechaInscripcion = DateTime.Parse(reader["fechaInscripcion"].ToString());

                        string nombreAlumno = ObtenerNombreAlumnoDesdeLegajo(legajo);
                        string nombreCurso = ObtenerNombreCursoDesdeCodigo(codigoCurso);
                        Carrera carrera = DevolverCarreraDedeCodigoCurso(codigoCurso);

                        RegistroDeInscripcion registroInscripcionReconstruido = new RegistroDeInscripcion(legajo, nombreAlumno, nombreCurso, codigoCurso, carrera, fechaInscripcion);

                        _listaRegistrosInscripcion.Add(registroInscripcionReconstruido);
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

        ////////////////////////CREATE
        internal static void IngresarNuevoRegistro(RegistroDeInscripcion nuevoRegistro)
        {
            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO RegistroInscripcion (legajo, codigoCurso, fechaInscripcion) " +
                    "VALUES (@legajo, @codigoCurso, @fechaInscripcion)";

                command.Parameters.AddWithValue("@legajo", nuevoRegistro.Legajo);
                command.Parameters.AddWithValue("@codigoCurso", nuevoRegistro.CodigoCurso);
                command.Parameters.AddWithValue("@fechaInscripcion", nuevoRegistro.Fecha);

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

            CrearInstanciasDeInscripcionesAPartirDeBD();
            RefrescarEstudianteLogueado();
        }

        ////////////////////////READ

        //METODO PARA OBTENER INSCRIPCIONES SEGUN PERIODO
        public static List<RegistroDeInscripcion> ObtenerInscripciones(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<RegistroDeInscripcion> resultados = new List<RegistroDeInscripcion>();

            // Recorro la lista de registros de inscripción
            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta)
                {
                    resultados.Add(registro);
                }
            }

            return resultados;
        }

        //SOBRECARGA DEL METODO. OBTIENE INSCRIPCIONES SEGUN T (CODIGO DE CURSO O CARRERA)
        public static List<RegistroDeInscripcion> ObtenerInscripciones<T>(DateTime fechaDesde, DateTime fechaHasta, T filtro)
        {
            // Creo una lista para ir guardando los resultados de las inscripciones que cumplan con los criterios
            List<RegistroDeInscripcion> resultados = new List<RegistroDeInscripcion>();

            // Recorro la lista de registros de inscripción
            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                // Verificamos si la fecha de inscripción del registro está dentro del rango especificado
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta)
                {
                    // Si el tipo de T es string, comparamos el filtro con el código de curso del registro
                    if (typeof(T) == typeof(string) && filtro.Equals(registro.CodigoCurso))
                    {
                        resultados.Add(registro);
                    }
                    // Si el tipo de T es Carrera (enum), comparamos el filtro con la Carrera del registro
                    else if (typeof(T) == typeof(Carrera) && filtro.Equals(registro.Carrera))
                    {
                        resultados.Add(registro);
                    }
                }
            }

            // Devuelvo la lista de resultados
            return resultados;
        }

        //////////////DELETE
        internal static void EliminarCursoATodosLosEstudiantes(string codigo)
        {
            try
            {
                connection.Open();

                command.CommandText = "DELETE FROM RegistroInscripcion WHERE codigoCurso = @codigo";

                command.Parameters.AddWithValue("@codigo", codigo);

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

            CrearInstanciasDeInscripcionesAPartirDeBD();
            RefrescarEstudianteLogueado();
        }

        ///////// REFRESCAR ESTUDIANTE LOGUEADO
        public static void RefrescarEstudianteLogueado()
        {
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.CorreoEstudianteLogueado);
        }

        //Getters y Setters
        public static List<RegistroDeInscripcion> Inscripciones { get { return _listaRegistrosInscripcion; } }
    }
}
