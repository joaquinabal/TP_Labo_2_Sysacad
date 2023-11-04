using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        protected static bool ComprobarExistenciaErrores(List<string> listaDeErrores)
        {
            return listaDeErrores.Count > 0;
        }

        protected static List<string> ObtenerListaDeCamposDesdeDiccionario(Dictionary<string, string> diccionarioConCampos)
        {
            return new List<string>(diccionarioConCampos.Values);
        }
    }
}
