using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosCursos
    {
        //Lista que contiene todos los cursos
        private List<Curso> _listaCursos = new List<Curso>();

        public BaseDatosCursos(string url) 
        {
            //Agrego los cursos por defecto
            _listaCursos = GenerarCursosPorDefecto();

            this._listaCursos = SerializadorJson.CargarCursosDesdeArchivoJson(url);
        }

        //Busqueda de curso existente en la base de datos
        public bool BuscarCursoBD(string codigo)
        {
            bool resultadoBusqueda = false;

            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigo)
                {
                    resultadoBusqueda = true;
                }
            }
            return resultadoBusqueda;
        }

        //CRUD DEL CURSO:
        public void IngresarCursoBD(Curso nuevoCurso)
        {
            _listaCursos.Add(nuevoCurso);
        }

        public void EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupo, string turno, string dia, string aula)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigoABuscar)
                {
                    curso.Nombre = nombre;
                    curso.Codigo = codigo;
                    curso.Descripcion = descripcion;
                    curso.CupoMaximo = cupo;
                    curso.Turno = turno;
                    curso.Dia = dia;
                    curso.Aula = aula;
                }
            }
        }

        public void EliminarCursoBD(string codigoABuscar)
        {
            List<Curso> cursosAEliminar = new List<Curso>();

            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigoABuscar)
                {
                    cursosAEliminar.Add(curso);
                }
            }

            foreach (Curso curso in cursosAEliminar)
            {
                _listaCursos.Remove(curso);
            }
        }

        //Restar 1 al cupo disponible de un determinado curso
        public void RestarCupoDisponible(Curso cursoARestarCupo)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == cursoARestarCupo.Codigo)
                {
                    curso.CupoDisponible -= 1;
                }
            }
        }

        //Metodo para devolver cursos dependiendo de si tienen cupo disponible o no
        public List<Curso> DevolverCursosDisponibles()
        {
            List<Curso> listaCursosDisponibles = new List<Curso>();
            foreach (Curso curso in _listaCursos)
            {
                if (curso.CupoDisponible > 0)
                {
                    listaCursosDisponibles.Add(curso);
                }
            }
            return listaCursosDisponibles;
        }

        public static List<Curso> GenerarCursosPorDefecto()
        {
            string[] nombresCursos =
            {"Matematica", "Sistemas de Procesamiento de Datos", "Ingles 1",
            "Programacion 1", "Laboratorio 1", "Arquitectura y Sistemas Operativos",
            "Estadistica", "Ingles 2", "Programacion 2", "Laboratorio 2", "Metodologia de Investigacion"};

            string[] turnos = { "Mañana", "Tarde", "Noche" };

            List<Curso> cursos = new List<Curso>();

            Random random = new Random();

            foreach (string nombreCurso in nombresCursos)
            {
                foreach (string turno in turnos)
                {
                    int cupoMaximo = random.Next(80, 160);
                    string codigo = GenerarCodigo(nombreCurso, turno);
                    string descripcion = $"1° año {nombreCurso.ToLower()} {turno.ToLower()}";
                    int aula = (turno == "Tarde") ? random.Next(100, 199) : (turno == "Mañana") ? random.Next(200, 299) : random.Next(300, 399);
                    string dia = GenerarDiaAleatorio();

                    Curso curso = new Curso(nombreCurso, codigo, descripcion, cupoMaximo, turno, aula.ToString(), dia);
                    cursos.Add(curso);
                }
            }

            return cursos;
        }

        public static string GenerarCodigo(string nombreCurso, string turno)
        {
            string codigo = $"{nombreCurso.Substring(0, 4)}{turno.Substring(0, 1)}";
            return codigo;
        }

        public static string GenerarDiaAleatorio()
        {
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            Random random = new Random();
            int indice = random.Next(0, dias.Length);
            return dias[indice];
        }


        //Getters y setters
        public List<Curso> Cursos { get { return _listaCursos; } }
    }
}
