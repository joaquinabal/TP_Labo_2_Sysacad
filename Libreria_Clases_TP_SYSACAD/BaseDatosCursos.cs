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

        //Cursos por defecto
        private static Curso _cursoPorDefecto1 = new Curso("Programacion I", "Prog1", "1° año programacion", 150);
        private static Curso _cursoPorDefecto2 = new Curso("Ingles I", "Ing1", "1° año ingles", 80);
        private static Curso _cursoPorDefecto3 = new Curso("Matematica", "Mat1", "1° año matematica", 85);

        public BaseDatosCursos(string url) 
        {
            //Ingreso los cursos por defecto a la base de datos
            //IngresarCursoBD(_cursoPorDefecto1);
            //IngresarCursoBD(_cursoPorDefecto2);
            //IngresarCursoBD(_cursoPorDefecto3);

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

        public void EditarCursoBD(string codigoABuscar, string nombre, string codigo, string descripcion, int cupo)
        {
            foreach (Curso curso in _listaCursos)
            {
                if (curso.Codigo == codigoABuscar)
                {
                    curso.Nombre = nombre;
                    curso.Codigo = codigo;
                    curso.Descripcion = descripcion;
                    curso.CupoMaximo = cupo;
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

        //Getters y setters
        public List<Curso> Cursos { get { return _listaCursos; } }
    }
}
