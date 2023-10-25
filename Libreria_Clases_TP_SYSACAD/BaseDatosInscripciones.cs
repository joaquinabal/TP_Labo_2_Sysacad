using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosInscripciones
    {
        private List<RegistroDeInscripcion> _listaRegistrosInscripcion = new List<RegistroDeInscripcion>();

        internal BaseDatosInscripciones()
        {
            List<RegistroDeInscripcion>? registrosCargados = ArchivosJSONInscripciones.CargarInscripcionesDesdeArchivoJson();

            if (registrosCargados != null)
            {
                _listaRegistrosInscripcion = registrosCargados;
            }
        }

        internal void IngresarNuevoRegistro(RegistroDeInscripcion nuevoRegistro)
        {
            try
            {
                _listaRegistrosInscripcion.Add(nuevoRegistro);
                ArchivosJSONInscripciones.GuardarArchivoJSON(_listaRegistrosInscripcion);
            }
            catch (IOException ex)
            {
                // Manejo específico de excepciones de entrada/salida al guardar el archivo JSON.
                Console.WriteLine("Error al guardar el archivo JSON: " + ex.Message);
            }
        }

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
                if (registro.FechaInscripcion >= fechaDesde && registro.FechaInscripcion <= fechaHasta)
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

        //Getters y Setters
        public List<RegistroDeInscripcion> Inscripciones { get { return _listaRegistrosInscripcion; } }
    }
}
