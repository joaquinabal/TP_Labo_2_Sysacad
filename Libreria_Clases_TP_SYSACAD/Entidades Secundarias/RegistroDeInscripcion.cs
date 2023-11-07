using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;

namespace Libreria_Clases_TP_SYSACAD.EntidadesSecundarias
{
    //public enum Carrera
    //{
    //    TUP,
    //    TUSI
    //}

    public class RegistroDeInscripcion : IRegistroEstadistico, IEntidadReconstruida
    {
        private string _legajo;
        private string _nombreAlumno;
        private string _nombreCurso;
        private string _codigoCurso;
        private Carrera _carrera;
        private DateTime _fechaInscripcion;

        public RegistroDeInscripcion(string legajo, string nombreAlumno, string nombreCurso, string codigoCurso, Carrera carrera, DateTime fechaInscripcion)
        {
            _legajo = legajo;
            _nombreAlumno = nombreAlumno;
            _nombreCurso = nombreCurso;
            _codigoCurso = codigoCurso;
            _carrera = carrera;
            _fechaInscripcion = fechaInscripcion;
        }

        //Getters y Setters
        public string Legajo { get { return _legajo; } }

        public string NombreAlumno { get { return _nombreAlumno; } }

        public string NombreCurso { get { return _nombreCurso; } }

        public string CodigoCurso { get { return _codigoCurso; } }

        public Carrera Carrera { get { return _carrera; } }

        public DateTime Fecha { get { return _fechaInscripcion; } }
    }
}
