using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Estudiante
    {
        private string _nombre;
        private string _legajo;
        private string _direccion;
        private string _numeroTelefono;
        private string _correo;
        private string _contraseñaProvisional;
        private Guid _identificadorUnico;
        private bool _debeCambiarContraseña;

        public Estudiante(string nombre, string legajo, string direccion, string telefono,
            string correo, string contraseñaProv, bool debeCambiarContraseña)
        {
            _nombre = nombre;
            _legajo = legajo;
            _direccion = direccion;
            _numeroTelefono = telefono;
            _correo = correo;
            _contraseñaProvisional = contraseñaProv;
            _debeCambiarContraseña = debeCambiarContraseña;
        }

        public void RegistrarEstudiante(Estudiante nuevoEstudiante)
        {
            Sistema.baseDatosEstudiantes.IngresarUsuarioBD(nuevoEstudiante);
        }

        public string Legajo 
        { 
            get 
            {
                return _legajo;
            } 
        }

        public string Correo
        {
            get
            {
                return _correo;
            }
        }

        public Guid IdentificadorUnico
        {
            set
            {
                _identificadorUnico = value;
            }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public string NumeroTelefono
        {
            get { return _numeroTelefono; }
        }

        public string ContraseñaProvisional
        {
            get { return _contraseñaProvisional; }
        }
    }
}
