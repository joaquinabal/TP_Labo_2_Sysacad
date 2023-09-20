using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    /// <summary>
    /// Validaciones respectivas de la entidad curso
    /// </summary>
    class ValidacionesCurso : ValidarEntidades
    {
        /// <summary>
        /// Valida si existe un curso dentro de la lista de estos
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>
        /// Retorna true si pudo encontrar el curso en la lista, caso contrario retorna false
        /// </returns>
        public static bool ComprobarSiCursoExiste(string codigo)
        {
            bool resultadoBusqueda = false;

            foreach (Curso curso in BaseDatosCursos.Cursos)
            {
                if (curso.Codigo == codigo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }

        /// <summary>
        /// Valida que todos los campos del curso sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="cupo"></param>
        /// <returns> retorna true si esta todo bien, caso contrario devuelve false</returns>
        public static bool ValidarIngresoDatosCurso(string nombre, string codigo, string descripcion, int cupo)
        {
            if (ValidarNombreCurso(nombre) || ValidarCodigoCurso(codigo) 
                || ValidarIngresoNull(descripcion) || ValidarCupoCurso(cupo))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el parametro nombre sea distinto de null
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>retorna true si el nombre del curso no es null, caso contrario devuelve false</returns>
        public static bool ValidarNombreCurso(string nombre)
        {
            if (ValidarIngresoNull(nombre))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Valida el codigo del curso de ingreso no sea null
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>retorna true si no es null, caso contrario es false</returns>
        public static bool ValidarCodigoCurso(string codigo)
        {
            if (ValidarIngresoNull(codigo))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el cupo en el curso no sea 0
        /// </summary>
        /// <param name="cupo"></param>
        /// <returns>Retorna false si el curso es 0, caso contrario devuelve true</returns>
        public static bool ValidarCupoCurso(int cupo)
        {
            if (cupo == 0)
                return false;
            else
                return true;
        }
    }
}
