using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public static class ValidadorDuplicados
    {

        public static bool ValidarDuplicadosEstudiantes(string legajo, string correo)
        {
            return ConsultasEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
        }

    }
}
