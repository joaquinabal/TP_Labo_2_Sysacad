using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public enum Log { Admin, Estudiante, Curso }

    public abstract class ValidadorInputs
    {
        /// <summary>
        /// Valida si una lista de cadenas de texto contiene campos vacíos o nulos.
        /// </summary>
        /// <param name="campos">La lista de cadenas de texto a validar.</param>
        /// <returns>True si no hay campos vacíos o nulos; de lo contrario, false.</returns>
        protected static bool ValidarCampos(List<string> campos)
        {
            bool resultado = true;

            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo))
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Valida si una cadena de texto de contraseña está vacía o nula.
        /// </summary>
        /// <param name="contrasenia">La cadena de texto que representa la contraseña.</param>
        /// <returns>True si la contraseña no está vacía ni nula; de lo contrario, false.</returns>
        protected static bool ValidarCampos(string contrasenia)
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                resultado = false;
            }

            return resultado;
        }

        //Metodo para aplicar polimorfismo 
        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        //Sobrecarga del metodo para aplicar polimorfismo 
        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoPago modo)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoValidacionInputCurso modo)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        /// <summary>
        /// Comprueba si una lista de errores contiene algún error.
        /// </summary>
        /// <param name="listaDeErrores">La lista de errores a comprobar.</param>
        /// <returns>True si la lista contiene errores; de lo contrario, false.</returns>
        protected static bool ComprobarExistenciaErrores(List<string> listaDeErrores)
        {
            bool resultadoErrores = false;

            foreach (string error in listaDeErrores)
            {
                if (listaDeErrores.Count > 0)
                {
                    resultadoErrores = true;
                    break;
                }
            }

            return resultadoErrores;
        }

        /// <summary>
        /// Obtiene una lista de campos a partir de un diccionario que contiene campos y valores.
        /// </summary>
        /// <param name="diccionarioConCampos">El diccionario que contiene campos y valores.</param>
        /// <returns>Una lista de cadenas de texto que representan los campos.</returns>
        protected static List<string> ObtenerListaDeCamposDesdeDiccionario(Dictionary<string, string> diccionarioConCampos)
        {
            List<string> listaCamposIngresados = new List<string>();

            foreach (string valor in diccionarioConCampos.Values)
            {
                listaCamposIngresados.Add(valor);
            }

            return listaCamposIngresados;
        }
    }
}
