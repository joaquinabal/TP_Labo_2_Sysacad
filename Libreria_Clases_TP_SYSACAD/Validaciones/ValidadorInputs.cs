using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public abstract class ValidadorInputs
    {
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

        protected static bool ValidarCampos(string contrasenia)
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                resultado = false;
            }

            return resultado;
        }

        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        //Sobrecarga del metodo para aplicar polimorfismo 
        protected virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoValidacionInput modo)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        protected static bool ComprobarExistenciaErrores(List<string> listaDeErrores)
        {
            return listaDeErrores.Count > 0;
        }

        protected static List<string> ObtenerListaDeCamposDesdeDiccionario(Dictionary<string, string> diccionarioConCampos)
        {
            return new List<string>(diccionarioConCampos.Values);
        }

        protected void ValidarAlfanumerico(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo sea alfanumérico (letras y números) con espacios en blanco permitidos.
            if (!Regex.IsMatch(diccionario[campo], @"^[a-zA-Z0-9\s]+$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarNumeroExacto(string campo, Dictionary<string, string> diccionario, int longitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga un número exacto de dígitos especificado por 'longitud'.
            if (!Regex.IsMatch(diccionario[campo], $@"^\d{{{longitud}}}$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarNumeroConDecimal(string campo, Dictionary<string, string> diccionario, double maxValor, List<string> errores, string mensajeError)
        {
            // Valida que el campo sea un número con un valor máximo (puede tener hasta 2 decimales).
            if (!Regex.IsMatch(diccionario[campo], $@"^{maxValor}|\d(\.\d{{1,2}})?$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarNumerico(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga solo números.
            if (!Regex.IsMatch(diccionario[campo], @"^[0-9]+$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarCorreo(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga un formato de correo electrónico válido.
            if (!Regex.IsMatch(diccionario[campo], @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarNumeroRango(string campo, Dictionary<string, string> diccionario, int minLongitud, int maxLongitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo contenga un número en un rango específico de longitud.
            if (!Regex.IsMatch(diccionario[campo], $@"^\d{{{minLongitud},{maxLongitud}}}$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarMinLongitud(string campo, Dictionary<string, string> diccionario, int minLongitud, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga al menos una longitud mínima especificada.
            if (!Regex.IsMatch(diccionario[campo], $@"^[a-zA-Z0-9]{{{minLongitud},}}$"))
            {
                errores.Add(mensajeError);
            }
        }

        protected void ValidarFormatoFecha(string campo, Dictionary<string, string> diccionario, List<string> errores, string mensajeError)
        {
            // Valida que el campo tenga un formato de fecha MM/YY válido.
            if (!Regex.IsMatch(diccionario[campo], @"^(0[1-9]|1[0-2])/\d{2}$"))
            {
                errores.Add(mensajeError);
            }
        }
    }
}
