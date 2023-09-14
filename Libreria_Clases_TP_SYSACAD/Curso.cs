using System;
using System.Collections.Generic;
using System.Linq;
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

        public Curso(string nombre, string codigo, string descripcion, int cupoMaximo) 
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;
        }

        //Llamo a este metodo desde el Forms, tras validar el curso para ingresarlo a la BD
        public void RegistrarCurso(Curso nuevoCurso)
        {
            Sistema.BaseDatosCursos.IngresarCursoBD(nuevoCurso);
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
