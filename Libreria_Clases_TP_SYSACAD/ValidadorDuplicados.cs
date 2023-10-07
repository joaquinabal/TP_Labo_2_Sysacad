using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ValidadorDuplicados
    {
        /// <summary>
        /// Valida duplicados de cursos en la base de datos.
        /// </summary>
        /// <param name="codigo">El código del curso a validar.</param>
        /// <returns>true si se encuentra un curso con el mismo código en la base de datos, de lo contrario, false.</returns>
        public static bool ValidarDuplicados(string codigo)
        {
            bool resultadoBusquedaUsuario = false;

            resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: Log.Curso, codigo: codigo);

            return resultadoBusquedaUsuario;
        }

        /// <summary>
        /// Valida duplicados de estudiantes en la base de datos.
        /// </summary>
        /// <param name="legajo">El legajo del estudiante a validar.</param>
        /// <param name="correo">El correo del estudiante a validar.</param>
        /// <returns>true si se encuentra un estudiante con el mismo legajo o correo en la base de datos, de lo contrario, false.</returns>
        public static bool ValidarDuplicados(string legajo, string correo)
        {
            bool resultadoBusquedaUsuario = false;

            resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: Log.Estudiante, correo: correo, legajo: legajo);

            return resultadoBusquedaUsuario;
        }

        /// <summary>
        /// Comprueba la existencia previa de un curso o estudiante en la base de datos.
        /// </summary>
        /// <param name="modo">El modo de validación (Curso o Estudiante).</param>
        /// <param name="correo">El correo del estudiante a validar (solo en modo Estudiante).</param>
        /// <param name="codigo">El código del curso a validar (solo en modo Curso).</param>
        /// <param name="legajo">El legajo del estudiante a validar (solo en modo Estudiante).</param>
        /// <returns>true si se encuentra un registro duplicado en la base de datos, de lo contrario, false.</returns>
        public static bool ComprobarExistenciaPrevia(Log modo, string correo = null, string codigo = null, string legajo = null)
        {
            bool resultadoBusquedaUsuario = false;

            if (modo == Log.Curso)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosCursos.BuscarCursoBD(codigo);
            }
            else if (modo == Log.Estudiante)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
            }

            return resultadoBusquedaUsuario;
        }
    }
}
