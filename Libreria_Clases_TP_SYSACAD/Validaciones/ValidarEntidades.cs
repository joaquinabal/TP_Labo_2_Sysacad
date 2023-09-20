using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    /// <summary>
    /// Esta clase servirá para validar TEXTBOX EN BLANCO y datos duplicados en la BD. REFORMULAR
    /// Clase utilizada para validar los distintos tipos de validaciones de las entidades
    /// </summary>
    public static class ValidarEntidades
    {
        /// <summary>
        /// Valida si el correo el correo tiene el formato correcto
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contraseña"></param>
        /// <returns>
        /// Retorna true si pudo encontrar
        /// </returns>
        public static bool ValidarCorreo(string correo)
        {
            if (ValidarIngresoNull(correo) || ValidarIngresos.ValidacionesString.CorreoFormato(correo))          
                return false;            
            else        
                return true;      
        }
        ///
        /// <summary>
        /// Valida la contrasenia sea distinta de null
        /// </summary>
        /// <param name="contrasenia"></param>
        /// <returns>Retorna true si no es null, caso contrario devuelve false</returns>
        public static bool ValidarContrasenia(string contrasenia)
        {
            if (ValidarIngresoNull(contrasenia))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Valida que el input no sea null
        /// </summary>
        /// <param name="ingresoUsuario"></param>
        /// <returns>Retorna true si no es null, caso contrario devuelve false</returns>
        public static bool ValidarIngresoNull(string ingresoUsuario)
        {
            if (string.IsNullOrWhiteSpace(ingresoUsuario))
                return false;
            else
                return true;
        }

    }

}
