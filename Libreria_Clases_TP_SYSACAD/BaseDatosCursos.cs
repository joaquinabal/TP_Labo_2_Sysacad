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
        private List<Curso> _listaCursos = new List<Curso>();

        private static Curso _cursoPorDefecto1 = new Curso("Programacion I", "Prog1", "1° año programacion", 150);
        private static Curso _cursoPorDefecto2 = new Curso("Ingles I", "Ing1", "1° año ingles", 80);
        private static Curso _cursoPorDefecto3 = new Curso("Matematica", "Mat1", "1° año matematica", 85);

        public BaseDatosCursos() 
        {
            IngresarUsuarioBD(_cursoPorDefecto1);
            IngresarUsuarioBD(_cursoPorDefecto2);
            IngresarUsuarioBD(_cursoPorDefecto3);

            Debug.WriteLine("Datos de la base de cursos:");
            foreach (var curso in _listaCursos)
            {
                Debug.WriteLine($"Nombre: {curso.Nombre}, Código: {curso.Codigo}, Descripción: {curso.Descripcion}, Cupo Máximo: {curso.CupoMaximo}");
            }

        }

        public void IngresarUsuarioBD(Curso nuevoCurso)
        {
            _listaCursos.Add(nuevoCurso);
        }

        public List<Curso> Cursos
        {
            get
            {
                return _listaCursos;
            }
        }
    }
}
