using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    /// <summary>
    /// Clase que contiene las validaciones correspondientes a administradores
    /// </summary>
    class ValidacionesAdministradores
    {
        /// <summary>
        /// Comprueba si existe el correo administrador en la lista de estos
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contraseña"></param>
        /// <returns> retorna true si pudo encontrar el correo, caso contrario devuelve false</returns>
        public static bool ComprobarSiCorreoAdminExiste(string correo, string contraseña)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in BaseDatosAdministradores.Administradores)
            {
                if (administrador.Correo == correo)
                {
                    resultadoBusqueda = true;
                }
            }

            return resultadoBusqueda;
        }
    }
}
