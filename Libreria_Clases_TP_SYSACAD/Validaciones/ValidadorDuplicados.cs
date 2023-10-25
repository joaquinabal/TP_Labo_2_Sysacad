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
        public static bool ValidarDuplicados(string codigo)
        {
            return ComprobarExistenciaPrevia(codigo);
        }

        public static bool ValidarDuplicados(string legajo, string correo)
        {
            return ComprobarExistenciaPrevia(legajo, correo);
        }

        private static bool ComprobarExistenciaPrevia(string codigo)
        {
            return Sistema.BaseDatosCursos.BuscarCursoBD(codigo);
        }

        private static bool ComprobarExistenciaPrevia(string legajo, string correo)
        {
            return Sistema.BaseDatosEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
        }
    }
}
