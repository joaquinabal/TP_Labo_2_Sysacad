using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Curso
    {
        //Atributos que debe contener todo curso
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private int _cupoMaximo;
        private int _cupoDisponible;
        private List<Estudiante> _estudiantesInscriptos;

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo) 
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
            _cupoDisponible = cupoMaximo;
            _estudiantesInscriptos = new List<Estudiante>();    
        }

        //Llamo a este metodo desde el Forms, tras validar el curso para ingresarlo a la BD
        public void RegistrarCurso(Curso nuevoCurso)
        {
            Sistema.BaseDatosCursos.IngresarCursoBD(nuevoCurso);
        }

        public bool ChequearCuposDisponibles(Curso curso)
        {
            if (curso.CupoDisponible > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarEstudianteACurso(Estudiante estudiante, Curso curso)
        {
            curso.EstudiantesInscriptos.Add(estudiante);
        }

        public static Curso operator - (Curso curso, int numero)
        {
            curso.CupoDisponible -= numero;
            return curso;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value;}
        }

        public int CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value;}
        }
        public int CupoDisponible
        {
            get { return _cupoDisponible; }
            set { _cupoDisponible = value; }
        }

        public List<Estudiante> EstudiantesInscriptos
        {
            get { return _estudiantesInscriptos; }
        }
    }
}
