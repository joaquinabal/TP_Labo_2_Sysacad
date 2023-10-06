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

        private static string _codigoDeAccesoAdmins = "ts5bf4";

        public static void InicializarSistema()
        {
            try
            {
                _baseDatosAdministradores = new BaseDatosAdministradores();
                _baseDatosEstudiantes = new BaseDatosEstudiantes();
                _baseDatosCursos = new BaseDatosCursos();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e.InnerException);
            }
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

        public static string CodigoAccesoAdmins { get { return _codigoDeAccesoAdmins; } }
    }
}
