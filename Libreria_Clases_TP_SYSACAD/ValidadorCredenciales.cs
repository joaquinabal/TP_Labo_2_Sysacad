using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorCredenciales : Validador
    {
        //Esta clase valida si las credenciales de inicio de sesion son correctas y si los campos se llenaron.
        //Presenta dos modos "ADMIN" y "ESTUDIANTE", ya que dependiendo del modo deberá hacer la busqueda
        //en la base de datos correspondiente.
        //Devuelve el resultado de la validacion en forma de mensaje

        public string ValidarCredenciales(string correo, string contraseña, string modo)
        {
            string mensajeADevolver = string.Empty;

            List<string> listaCamposAValidar = new List<string>();
            listaCamposAValidar.Add(correo);
            listaCamposAValidar.Add(contraseña);

            bool resultadoValidacionCampos = ValidarCampos(listaCamposAValidar);

            //Validamos en base al modo
            bool resultadoBusquedaUsuario = false;
            if (modo == "ADMIN")
            {
                resultadoBusquedaUsuario = ValidarUsuarioEnBD(correo, contraseña, "ADMIN");
            }
            else
            {
                resultadoBusquedaUsuario = ValidarUsuarioEnBD(correo, contraseña, "ESTUDIANTE");
            }

            //Devolvemos el mensaje de acuerdo a los resultados de las validaciones
            if (resultadoValidacionCampos && resultadoBusquedaUsuario)
            {
                mensajeADevolver = "OK";
            }
            else if (!resultadoValidacionCampos)
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }
            else if (!resultadoBusquedaUsuario)
            {
                mensajeADevolver = "NO ENCONTRADO";
            }

            return mensajeADevolver;
        }

        public static bool ValidarUsuarioEnBD(string correo, string contraseña, string modo)
        {
            bool resultadoBusquedaUsuario = false;
            
            if (modo == "ADMIN")
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosAdministradores.BuscarUsuarioBD(correo, contraseña);
            }
            else if (modo == "ESTUDIANTE")
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioCredencialesBD(correo, contraseña);
            }

            return resultadoBusquedaUsuario;
        }
    }
}
