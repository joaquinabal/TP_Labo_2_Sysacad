using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Persistencia;

namespace Libreria_Clases_TP_SYSACAD.EntidadesPrimarias
{
    public static class Sistema
    {
        private static Estudiante _estudianteLogueado;
        private static RegistroExcepciones _registroExcepciones;
        private static string _correoEstudianteLogueado;

        //Codigo de acceso que solo los admins poseen
        private static string _codigoDeAccesoAdmins = "ts5bf4";

        public static void InicializarSistema()
        {
            ConsultasCursos.CrearInstanciasDeCursoAPartirDeBD();
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            ConsultasInscripciones.CrearInstanciasDeInscripcionesAPartirDeBD();
            ConsultasPagos.CrearInstanciasDePagosAPartirDeBD();
            ConsultasProfesores.CrearInstanciasDeProfesoresAPartirDeBD();

            _registroExcepciones = new RegistroExcepciones();
        }

        /// <summary>
        /// Establece un estudiante como usuario activo en el sistema.
        /// </summary>
        /// <param name="correo">El correo del estudiante que se desea establecer como usuario activo.</param>
        public static void IngresarEstudianteComoUsuarioActivo(string correo)
        {
            foreach (Estudiante estudiante in ConsultasEstudiantes.Estudiantes)
            {
                if (correo == estudiante.Correo)
                {
                    _estudianteLogueado = estudiante;
                }
            }
        }

        //Getters y Setters
        public static Estudiante EstudianteLogueado { get { return _estudianteLogueado; } set { _estudianteLogueado = value; } }

        public static string CorreoEstudianteLogueado { get { return _correoEstudianteLogueado; } set { _correoEstudianteLogueado = value; } }

        public static string CodigoAccesoAdmins { get { return _codigoDeAccesoAdmins; } }
    }
}
