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
        private List<RegistroDeInscripcion> _listaRegistrosInscripcion = new List<RegistroDeInscripcion>();

        /////////////////// RECONSTRUCCION DE LA LISTA DE INSCRIPCIONES A PARTIR DE BD
        internal static string ObtenerNombreAlumnoDesdeLegajo(string legajo)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT nombre FROM Estudiante WHERE legajo = @legajo";

                command.Parameters.AddWithValue("@legajo", legajo);

                string nombreAlumno = "";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombreAlumno = reader["codigoCurso"].ToString();
                    }
                }

                return nombreAlumno;
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

        private string ObtenerNombreCursoDesdeCodigo(string codigo)
        {
            try
            {
                connection.Open();

                command.CommandText = "SELECT nombre FROM Curso WHERE codigo = @codigo";

                command.Parameters.AddWithValue("@codigo", codigo);

                string nombreCurso = "";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombreCurso = reader["nombre"].ToString();
                    }
                }

                return nombreCurso;
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

        internal void CrearInstanciasDeInscripcionesAPartirDeBD()
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
                        Carrera carrera = (Carrera)Enum.Parse(typeof(Carrera), reader["carreraCodigo"].ToString());

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
        internal void IngresarNuevoRegistro(RegistroDeInscripcion nuevoRegistro)
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
        }

        ////////////////////////READ

        //METODO PARA OBTENER INSCRIPCIONES SEGUN PERIODO
        public List<RegistroDeInscripcion> ObtenerInscripciones(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<RegistroDeInscripcion> resultados = new List<RegistroDeInscripcion>();

            // Recorro la lista de registros de inscripción
            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                resultados.Add(registro);
            }

            return resultados;
        }

        //SOBRECARGA DEL METODO. OBTIENE INSCRIPCIONES SEGUN T (CODIGO DE CURSO O CARRERA)
        public List<RegistroDeInscripcion> ObtenerInscripciones<T>(DateTime fechaDesde, DateTime fechaHasta, T filtro)
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
        internal void EliminarCursoATodosLosEstudiantes(string codigo)
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
        }

        //Getters y Setters
        public List<RegistroDeInscripcion> Inscripciones { get { return _listaRegistrosInscripcion; } }
    }
}
