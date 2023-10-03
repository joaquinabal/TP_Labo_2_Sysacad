using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    enum ModoCurso { Agregar, EditarDup}

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
        private List<Estudiante> _estudiantesInscriptos;

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

            _estudiantesInscriptos = new List<Estudiante>();
        }

        //En caso que el admin cree un nuevo curso, se lo agrega a la BD
        public void RegistrarCurso(Curso nuevoCurso)
        {
            Sistema.BaseDatosCursos.IngresarCursoBD(nuevoCurso);
        }

        //Al querer inscribirse el alumno, se chequea si hay cupos disponibles
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

        public void AgregarEstudianteACurso(Estudiante estudiante, Curso curso)
        {
            curso.EstudiantesInscriptos.Add(estudiante);
        }

        //public string GenerarDiasAleatorios()
        //{
        //    string dia = "";
        //    Random random = new Random();
        //    int numeroRandom = random.Next(0, 4);
        //    switch (numeroRandom)
        //    {
        //        case 0:
        //            dia = "Lunes";
        //            break;
        //        case 1:
        //            dia = "Martes";
        //            break;
        //        case 2:
        //            dia = "Miercoles";
        //            break;
        //        case 3:
        //            dia = "Jueves";
        //            break;
        //        case 4:
        //            dia = "Viernes";
        //            break;
        //    }
        //    return dia;
        //}

        //public string GenerarTurnosAleatorios()
        //{
        //    string turno = "";
        //    Random random = new Random();
        //    int numeroRandom = random.Next(0, 2);
        //    switch (numeroRandom)
        //    {
        //        case 0:
        //            turno = "Turno Mañana";
        //            break;
        //        case 1:
        //            turno = "Turno Tarde";
        //            break;
        //        case 2:
        //            turno = "Turno Noche";
        //            break;
        //    }
        //    return turno;
        //}

        //public int GenerarNumeroAulasAleatorio()
        //{
        //    Random random = new Random();
        //    int numeroRandom = random.Next(100, 400);
        //    return numeroRandom;
        //}

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

        //Sobrecarga -
        public static Curso operator - (Curso curso, int numero)
        {
            curso.CupoDisponible -= numero;
            return curso;
        }

        //Setters y getters
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

        public string Turno
        {
            get { return _turno;  }
            set { _turno = value; }
        }

        public string Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }

        public string Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public List<Estudiante> EstudiantesInscriptos
        {
            get { return _estudiantesInscriptos; }
        }
    }
}
