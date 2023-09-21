using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class Validador
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
    }
}
