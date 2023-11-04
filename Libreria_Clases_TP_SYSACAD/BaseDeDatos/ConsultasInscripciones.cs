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

        internal static void CrearInstanciasDeInscripcionesAPartirDeBD()
        {
            _listaRegistrosInscripcion.Clear();
            _listaRegistrosInscripcion = CargaDeInstanciasDesdeBD.CrearInstanciasDeInscripcionesAPartirDeBD();
        }

        ////////////////////////CREATE
        internal static void IngresarNuevoRegistro(RegistroDeInscripcion nuevoRegistro)
        {
            string query = "INSERT INTO RegistroInscripcion (legajo, codigoCurso, fechaInscripcion) " +
                   "VALUES (@legajo, @codigoCurso, @fechaInscripcion)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@legajo", nuevoRegistro.Legajo },
                { "@codigoCurso", nuevoRegistro.CodigoCurso },
                { "@fechaInscripcion", nuevoRegistro.Fecha }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

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
            string query = "DELETE FROM RegistroInscripcion WHERE codigoCurso = @codigo";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@codigo", codigo }
            };

            ConsultasGenericas.EjecutarNonQuery(query, parametros);

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
