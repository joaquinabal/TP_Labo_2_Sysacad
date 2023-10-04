using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorInputNuevaContrasenia : ValidadorInputs
    {
        public string ValidarNuevaContrasenia(string contrasenia)
        {
            string mensajeADevolver = string.Empty;

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(contrasenia);

            //Valido si hay campos vacios y si el regex esta bien
            if (!resultadoCamposVacios)
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }
            else
            {
                if (!Regex.IsMatch(contrasenia, @"^[a-zA-Z0-9]{6,}$"))
                {
                    mensajeADevolver = "ERROR";
                }
                else
                {
                    mensajeADevolver = "OK";
                }
            }

            //Devuelvo la respuesta
            return mensajeADevolver;
        }

    }
}
