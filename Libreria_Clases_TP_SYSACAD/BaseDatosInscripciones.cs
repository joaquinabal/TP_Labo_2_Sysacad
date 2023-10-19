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

        public List<RegistroDeInscripcion> ObtenerInscripcionesTotalesSegunFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<RegistroDeInscripcion> listaInscripcionesSegunFecha = new List<RegistroDeInscripcion>();

            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                if (registro.FechaInscripcion >= fechaDesde && registro.FechaInscripcion <= fechaHasta)
                {
                    listaInscripcionesSegunFecha.Add(registro);
                }
            }

            return listaInscripcionesSegunFecha;
        }

        public List<RegistroDeInscripcion> ObtenerInscripcionesSegunCursoYFecha(DateTime fechaDesde, DateTime fechaHasta, string codigoCurso)
        {
            List<RegistroDeInscripcion> listaInscripcionesSegunCursoYFecha = new List<RegistroDeInscripcion>();

            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                if (registro.FechaInscripcion >= fechaDesde && registro.FechaInscripcion <= fechaHasta && registro.CodigoCurso == codigoCurso)
                {
                    listaInscripcionesSegunCursoYFecha.Add(registro);
                }
            }

            return listaInscripcionesSegunCursoYFecha;
        }

        public List<RegistroDeInscripcion> ObtenerInscripcionesSegunCarreraYFecha(DateTime fechaDesde, DateTime fechaHasta, Carrera carrera)
        {
            List<RegistroDeInscripcion> listaInscripcionesSegunCarreraYFecha = new List<RegistroDeInscripcion>();

            foreach (RegistroDeInscripcion registro in _listaRegistrosInscripcion)
            {
                if (registro.FechaInscripcion >= fechaDesde && registro.FechaInscripcion <= fechaHasta && registro.Carrera == carrera)
                {
                    listaInscripcionesSegunCarreraYFecha.Add(registro);
                }
            }

            return listaInscripcionesSegunCarreraYFecha;
        }

        //Getters y Setters
        public List<RegistroDeInscripcion> Inscripciones { get { return _listaRegistrosInscripcion; } }
    }
}
