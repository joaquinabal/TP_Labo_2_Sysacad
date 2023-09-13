using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ValidadorIngresoUsuario
    {
        public static bool ValidarCorreoYContraseña(string correo, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ComprobarSiUsuarioExiste(string correo, string contraseña)
        {
            bool resultadoBusqueda = false;

            foreach (Administrador administrador in Sistema.baseDatosAdministradores.Administradores)
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
