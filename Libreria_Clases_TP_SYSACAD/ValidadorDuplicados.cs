using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorDuplicados : Validador
    {
        //Esta clase valida si habrian registros duplicados al agregar algo nuevo en la BD y si los campos se llenaron.
        //Presenta tres modos "ADMIN", "CURSO" y "ESTUDIANTE", ya que dependiendo del modo deberá hacer la busqueda
        //en la base de datos correspondiente.
        //Devuelve el resultado de la validacion en forma de mensaje

        public string ValidarDuplicados(string modo, string correo = null, 
            string contraseña = null, string nombre = null, string codigo = null, string descripcion = null, 
            string cupo = null, string legajo = null, string direccion = null, 
            string telefono = null, string modoCurso = null, string turno = null, string dia = null, string aula = null)
        {
            string mensajeADevolver = string.Empty;

            List<string> listaCamposAValidar = new List<string>();

            bool resultadoBusquedaUsuario = false;

            //Valido campos y duplicidad segun modo
            if (modo == "ADMIN")
            {
                listaCamposAValidar.Add(correo);
                listaCamposAValidar.Add(contraseña);

                resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: "ADMIN", correo: correo);
            }
            else if (modo == "CURSO")
            {
                listaCamposAValidar.Add(nombre);
                listaCamposAValidar.Add(codigo);
                listaCamposAValidar.Add(descripcion);
                listaCamposAValidar.Add(cupo);
                listaCamposAValidar.Add(aula);
                listaCamposAValidar.Add(turno);
                listaCamposAValidar.Add(dia);

                if (modoCurso == "AGREGAR" || modoCurso == "EDITAR DUP")
                {
                    resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: "CURSO", codigo: codigo);
                }
            }
            else if (modo == "ESTUDIANTE")
            {
                listaCamposAValidar.Add(nombre);
                listaCamposAValidar.Add(legajo);
                listaCamposAValidar.Add(direccion);
                listaCamposAValidar.Add(telefono);
                listaCamposAValidar.Add(correo);
                listaCamposAValidar.Add(contraseña);

                resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: "ESTUDIANTE", correo: correo, legajo: legajo);
            }

            bool resultadoValidacionCampos = ValidarCampos(listaCamposAValidar);

            //Devolvemos el mensaje de acuerdo a los resultados de las validaciones
            if (resultadoValidacionCampos && !resultadoBusquedaUsuario)
            {
                mensajeADevolver = "OK";
            }
            else if (!resultadoValidacionCampos)
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }
            else if (resultadoBusquedaUsuario)
            {
                mensajeADevolver = "DUPLICADO";
            }

            return mensajeADevolver;
        }

        public static bool ComprobarExistenciaPrevia(string modo, string correo = null, string codigo = null, string legajo = null)
        {
            bool resultadoBusquedaUsuario = false;

            if (modo == "ADMIN")
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosAdministradores.BuscarUsuarioBD(correo);
            }
            else if (modo == "CURSO")
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosCursos.BuscarCursoBD(codigo);
            }
            else if (modo == "ESTUDIANTE")
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
            }

            return resultadoBusquedaUsuario;
        }
    }
}
