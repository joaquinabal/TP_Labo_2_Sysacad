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
        private string _turno;
        private string _aula;
        private string _dia;
        //private List<Estudiante> _estudiantesInscriptos;

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo, string turno, string aula, string dia)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
            _cupoDisponible = cupoMaximo;
            _turno = turno;
            _aula = aula;
            _dia = dia;

            //_estudiantesInscriptos = new List<Estudiante>();
        }

        /// <summary>
        /// Registra un nuevo curso en la base de datos.
        /// </summary>
        /// <param name="nuevoCurso">El curso a ser registrado.</param>
        public void RegistrarCurso(Curso nuevoCurso)
        {
            Sistema.BaseDatosCursos.IngresarCursoBD(nuevoCurso);
        }

        /// <summary>
        /// Verifica si hay cupos disponibles en el curso.
        /// </summary>
        /// <returns>True si hay cupos disponibles, False si no.</returns>
        public bool ChequearCuposDisponibles()
        {
            if (CupoDisponible > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void AgregarEstudianteACurso(Estudiante estudiante, Curso curso)
        //{
        //    curso.EstudiantesInscriptos.Add(estudiante);
        //}

        /// <summary>
        /// Devuelve el horario del curso en formato de texto.
        /// </summary>
        /// <returns>El horario del curso.</returns>
        public string DevolverHorario()
        {
            string horarioADevolver = "";

            switch (_turno)
            {
                case "Mañana":
                    horarioADevolver = "8:00 - 12:00 hs";
                    break;
                case "Tarde":
                    horarioADevolver = "14:00 - 18:00 hs";
                    break;
                case "Noche":
                    horarioADevolver = "18:30 - 22:30 hs";
                    break;
            }

            return horarioADevolver;
        }

        /// <summary>
        /// Sobrecarga del operador '-' para reducir el cupo disponible del curso.
        /// </summary>
        /// <param name="curso">El curso al que se reduce el cupo.</param>
        /// <param name="numero">La cantidad a restar al cupo disponible.</param>
        /// <returns>El curso con el cupo actualizado.</returns>
        public static Curso operator - (Curso curso, int numero)
        {
            curso.CupoDisponible -= numero;
            return curso;
        }

        //Setters y getters
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public string Codigo { get { return _codigo; } set { _codigo = value; } }

        public string Descripcion { get { return _descripcion; } set { _descripcion = value;} }

        public int CupoMaximo { get { return _cupoMaximo; } set { _cupoMaximo = value;} }

        public int CupoDisponible { get { return _cupoDisponible; } set { _cupoDisponible = value; } }

        public string Turno { get { return _turno;  } set { _turno = value; } }

        public string Aula { get { return _aula; } set { _aula = value; } }

        public string Dia { get { return _dia; } set { _dia = value; } }

        //public List<Estudiante> EstudiantesInscriptos { get { return _estudiantesInscriptos; } }
    }
}
