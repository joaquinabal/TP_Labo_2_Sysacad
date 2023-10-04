using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorCredenciales
    {
        
        //Esta clase valida si las credenciales de inicio de sesion son correctas y si los campos se llenaron.
        //Presenta dos modos "ADMIN" y "ESTUDIANTE", ya que dependiendo del modo deberá hacer la busqueda
        //en la base de datos correspondiente.
        //Devuelve el resultado de la validacion en forma de mensaje

        public string ValidarCredenciales(string correo, string contraseña, Log modo)
        {
            string mensajeADevolver = string.Empty;

            //Validamos en base al modo
            bool resultadoBusquedaUsuario = false;
            if (modo == Log.Admin)
            {
                resultadoBusquedaUsuario = ValidarUsuarioEnBD(correo, contraseña, Log.Admin);
            }
            else
            {
                resultadoBusquedaUsuario = ValidarUsuarioEnBD(correo, contraseña, Log.Estudiante);
            }

            //Devolvemos el mensaje de acuerdo a los resultados de las validaciones
            if(string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }
            else
            {
                if (resultadoBusquedaUsuario)
                {
                    mensajeADevolver = "OK";
                }
                else
                {
                    mensajeADevolver = "NO ENCONTRADO";
                }
            }

            return mensajeADevolver;
        }

        public static bool ValidarUsuarioEnBD(string correo, string contraseña, Log modo)
        {
            bool resultadoBusquedaUsuario = false;
            
            if (modo == Log.Admin)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosAdministradores.BuscarUsuarioBD(correo, contraseña);
            }
            else if (modo == Log.Estudiante)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioCredencialesBD(correo, contraseña);
            }

            return resultadoBusquedaUsuario;
        }

        public bool ValidarCodigoAccesoAdmins(string codigo)
        {
            if (codigo == Sistema.CodigoAccesoAdmins)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
