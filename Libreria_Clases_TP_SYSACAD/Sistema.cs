using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{

    public static class Sistema
    {
        //Creo esta clase estatica que se inicia sin necesidad de instanciarla, para poder crear las bases de datos.
        private static BaseDatosAdministradores _baseDatosAdministradores;
        private static BaseDatosEstudiantes _baseDatosEstudiantes;
        private static BaseDatosCursos _baseDatosCursos;
        private static Estudiante _estudianteLogueado;
        private static Administrador _administradorLogueado;

        private static string _codigoDeAccesoAdmins = "ts5bf4";

        public static void InicializarSistema()
        {
            //string response = "Se cargaron todos los archivos con éxito";

            _baseDatosAdministradores = new BaseDatosAdministradores();
            _baseDatosEstudiantes = new BaseDatosEstudiantes();
            _baseDatosCursos = new BaseDatosCursos();

            //List<string> mensajesError = new List<string>();

            //if (_baseDatosAdministradores.Administradores.Count <= 0)
            //{
            //    mensajesError.Add("La base de datos de administradores se encuentra vacía.");
            //}

            //if (_baseDatosEstudiantes.Estudiantes.Count <= 0)
            //{
            //    mensajesError.Add("La base de datos de estudiantes se encuentra vacía.");
            //}

            //if (_baseDatosCursos.Cursos.Count <= 0)
            //{
            //    mensajesError.Add("La base de datos de cursos se encuentra vacía.");
            //}

            //if (mensajesError.Count > 0)
            //{
            //    // Concatenar los mensajes de error
            //    response = string.Join(Environment.NewLine, mensajesError);
            //}

            //return response;
        }

        public static void IngresarEstudianteComoUsuarioActivo(string correo)
        {
            foreach (Estudiante estudiante in _baseDatosEstudiantes.Estudiantes)
            {
                if (correo == estudiante.Correo)
                {
                    _estudianteLogueado = estudiante;
                }
            }
        }

        //Getters y Setters
        public static BaseDatosAdministradores BaseDatosAdministradores { get { return _baseDatosAdministradores; } }

        public static BaseDatosEstudiantes BaseDatosEstudiantes { get { return _baseDatosEstudiantes; } }

        public static BaseDatosCursos BaseDatosCursos { get {  return _baseDatosCursos; } }

        public static Estudiante EstudianteLogueado { get { return _estudianteLogueado; } set { _estudianteLogueado = value; } }

        public static Administrador AdministradorLogueado { get { return _administradorLogueado; } set { _administradorLogueado = value; } }

        public static string CodigoAccesoAdmins { get { return _codigoDeAccesoAdmins; } }
    }
}
