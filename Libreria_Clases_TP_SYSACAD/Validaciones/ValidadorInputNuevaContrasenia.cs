using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public class ValidadorInputNuevaContrasenia : ValidadorInputs
    {

        /// <summary>
        /// Valida una nueva contraseña de acuerdo a ciertos criterios.
        /// </summary>
        /// <param name="contrasenia">La contraseña que se desea validar.</param>
        /// <returns>
        /// Un mensaje que indica el resultado de la validación:
        /// - "CAMPOS VACIOS" si la contraseña está vacía o nula.
        /// - "ERROR" si la contraseña no cumple con el formato requerido.
        /// - "OK" si la contraseña cumple con el formato requerido.
        /// </returns>
        public MensajeRespuestaValidacionCredencialesContraseña ValidarNuevaContrasenia(string contrasenia)
        {
            MensajeRespuestaValidacionCredencialesContraseña mensajeADevolver;

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(contrasenia);

            //Valido si hay campos vacios y si el regex esta bien
            if (!resultadoCamposVacios)
            {
                mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.camposVacios;
            }
            else
            {
                if (!Regex.IsMatch(contrasenia, @"^[a-zA-Z0-9]{6,}$"))
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.ERROR;
                }
                else
                {
                    mensajeADevolver = MensajeRespuestaValidacionCredencialesContraseña.OK;
                }
            }

            return mensajeADevolver;
        }

    }
}
