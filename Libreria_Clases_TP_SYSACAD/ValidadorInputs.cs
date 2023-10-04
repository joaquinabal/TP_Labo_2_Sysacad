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
        //Esta clase unicamente valida una lista de campos (Campos que el usuario llena en los Forms)
        //Devuelve true si estan todos llenos, y false si alguno lo está.
        //Todos los otros validadores heredan de esta clase, ya que validarán campos.

        public static bool ValidarCampos(List<string> campos)
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

        public static bool ValidarCampos(string contrasenia)
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                resultado = false;
            }

            return resultado;
        }

        public virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        public virtual List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoPago modo)
        {
            List<string> errores = new List<string>();
            return errores;
        }

        public static bool ComprobarExistenciaErrores(List<string> listaDeErrores)
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

        public static List<string> ObtenerListaDeCamposDesdeDiccionario(Dictionary<string, string> diccionarioConCampos)
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
