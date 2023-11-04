using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Entidades_Primarias
{
    public class Profesor
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _especializacion;
        private List<string> _codigosCursosDeProfesor = new List<string>();

        public Profesor(string nombre, string direccion, string telefono, string correo, string especializacion)
        {
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _correo = correo;
            _especializacion= especializacion;
        }

        public Profesor(string nombre, string direccion, string telefono, string correo, string especializacion, List<string> codigosCursosDeProfesor)
        {
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _correo = correo;
            _especializacion = especializacion;
            _codigosCursosDeProfesor = codigosCursosDeProfesor;
        }

        public void RegistrarProfesor()
        {
            ConsultasProfesores.IngresarNuevoProfesor(this);
        }

        public string Nombre { get { return _nombre; } }
        public string Direccion { get { return _direccion; } }
        public string Telefono { get { return _telefono; } }
        public string Correo { get { return _correo; } }
        public string Especializacion { get { return _especializacion; } }
        public List<string> CodigosCursosDeProfesor { get { return _codigosCursosDeProfesor; } }
    }
}
