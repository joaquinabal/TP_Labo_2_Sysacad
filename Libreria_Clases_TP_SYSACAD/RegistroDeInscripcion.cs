using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public enum Carrera
    {
        TUP,
        TUSI
    }

    public class RegistroDeInscripcion
    {
        private string _legajo;
        private string _nombreAlumno;
        private string _nombreCurso;
        private string _codigoCurso;
        private Carrera _carrera;
        private DateTime _fechaInscripcion;

        public RegistroDeInscripcion(Estudiante estudiante, Curso curso, DateTime fechaInscripcion)
        {
            _legajo = estudiante.Legajo;
            _nombreAlumno = estudiante.Nombre;
            _nombreCurso = curso.Nombre;
            _codigoCurso = curso.Codigo;
            _carrera = curso.Carrera;
            _fechaInscripcion = fechaInscripcion;
        }

        //Getters y Setters

        public string Legajo { get { return _legajo; } }

        public string NombreAlumno { get { return _nombreAlumno; } }

        public string NombreCurso { get { return _nombreCurso; } }

        public string CodigoCurso { get { return _codigoCurso; } }

        public Carrera Carrera { get { return _carrera; } }

        public DateTime FechaInscripcion { get { return _fechaInscripcion; } }
    }
}
