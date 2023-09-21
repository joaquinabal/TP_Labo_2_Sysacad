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
        private static BaseDatosAdministradores _baseDatosAdministradores = new BaseDatosAdministradores();
        private static BaseDatosEstudiantes _baseDatosEstudiantes = new BaseDatosEstudiantes();
        private static BaseDatosCursos _baseDatosCursos = new BaseDatosCursos();
        private static Estudiante _estudianteLogueado;
        private static Administrador _administradorLogueado;

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
    }
}
