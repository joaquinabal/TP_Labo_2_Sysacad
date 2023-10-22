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
        private static BaseDatosInscripciones _baseDatosInscripciones;
        private static BaseDatosPagos _baseDatosPagos;
        private static Estudiante _estudianteLogueado;

        //Codigo de acceso que solo los admins poseen
        private static string _codigoDeAccesoAdmins = "ts5bf4";

        /// <summary>
        /// Inicializa el sistema creando las bases de datos necesarias.
        /// </summary>
        public static void InicializarSistema()
        {
            try
            {
                _baseDatosCursos = new BaseDatosCursos();
                _baseDatosAdministradores = new BaseDatosAdministradores();
                _baseDatosEstudiantes = new BaseDatosEstudiantes();
                _baseDatosInscripciones = new BaseDatosInscripciones();
                _baseDatosPagos = new BaseDatosPagos();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e.InnerException);
            }
        }

        /// <summary>
        /// Establece un estudiante como usuario activo en el sistema.
        /// </summary>
        /// <param name="correo">El correo del estudiante que se desea establecer como usuario activo.</param>
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
        internal static BaseDatosAdministradores BaseDatosAdministradores { get { return _baseDatosAdministradores; } }

        public static BaseDatosEstudiantes BaseDatosEstudiantes { get { return _baseDatosEstudiantes; } }

        public static BaseDatosCursos BaseDatosCursos { get {  return _baseDatosCursos; } }

        public static BaseDatosInscripciones BaseDatosInscripciones { get { return _baseDatosInscripciones; } }

        public static BaseDatosPagos BaseDatosPagos { get { return _baseDatosPagos; } }

        public static Estudiante EstudianteLogueado { get { return _estudianteLogueado; } set { _estudianteLogueado = value; } }

        public static string CodigoAccesoAdmins { get { return _codigoDeAccesoAdmins; } }
    }
}
