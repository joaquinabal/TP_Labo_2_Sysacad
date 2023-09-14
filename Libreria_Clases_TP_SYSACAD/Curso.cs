using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Curso
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private int _cupoMaximo;

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo) 
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
        }

        public void RegistrarCurso(Curso nuevoCurso)
        {
            Sistema.BaseDatosCursos.IngresarUsuarioBD(nuevoCurso);
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Codigo
        {
            get { return _codigo; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public int CupoMaximo
        {
            get { return _cupoMaximo; }
        }


    }
}
