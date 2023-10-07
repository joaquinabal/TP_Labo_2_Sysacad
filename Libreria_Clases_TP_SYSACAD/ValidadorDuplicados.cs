using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public static class ValidadorDuplicados
    {
        //Esta clase valida si habrian registros duplicados al agregar algo nuevo en la BD y si los campos se llenaron.
        //Presenta tres modos "ADMIN", "CURSO" y "ESTUDIANTE", ya que dependiendo del modo deberá hacer la busqueda
        //en la base de datos correspondiente.
        //Devuelve el resultado de la validacion en forma de mensaje

        /* public string ValidarDuplicados(Log modo, string correo = null, 
             string contraseña = null, string nombre = null, string codigo = null, string descripcion = null, 
             string cupo = null, string legajo = null, string direccion = null, 
             string telefono = null, ModoCurso modoCurso = ModoCurso.Agregar, string turno = null, string dia = null, string aula = null)
         {
             string mensajeADevolver = string.Empty;

             List<string> listaCamposAValidar = new List<string>();

             bool resultadoBusquedaUsuario = false;

             //Valido campos y duplicidad segun modo
             if (modo == Log.Curso)
             {
                 if (modoCurso == ModoCurso.Agregar || modoCurso == ModoCurso.EditarDup)
                 {
                     resultadoBusquedaUsuario = ComprobarExistenciaPrevia(Log.Curso, codigo: codigo);
                 }
             }
             else if (modo == Log.Estudiante)
             {
                 resultadoBusquedaUsuario = ComprobarExistenciaPrevia(Log.Estudiante, correo: correo, legajo: legajo);
             }

             //Devolvemos el mensaje de acuerdo a los resultados de las validaciones
             if (!resultadoBusquedaUsuario)
             {
                 mensajeADevolver = "OK";
             }
             else if (resultadoBusquedaUsuario)
             {
                 mensajeADevolver = "DUPLICADO";
             }

             return mensajeADevolver;
         }*/

        // Para validar duplicados en modo Admin
        //public static bool ValidarDuplicadosA(Log modo, string correo)
        //{
        //    bool resultadoBusquedaUsuario = false;
        //    if (modo == Log.Admin)
        //    {
        //        resultadoBusquedaUsuario = ComprobarExistenciaPrevia(Log.Admin, correo);
        //    }
        //    return resultadoBusquedaUsuario;
        //}
        ////Valida duplicados en modo curso tanto para editar como para agregar
        //public static bool ValidarDuplicados(Log modo, ModoCurso modoCurso, string codigo)
        //{

        //    bool resultadoBusquedaUsuario = false;
        //    if (modo == Log.Curso)
        //    {
        //        if (modoCurso == ModoCurso.Agregar || modoCurso == ModoCurso.EditarDup)
        //        {
        //            resultadoBusquedaUsuario = ComprobarExistenciaPrevia(Log.Curso, codigo);
        //        }
        //    }
        //    return resultadoBusquedaUsuario;
        //}

        //Validar duplicados de curso
        public static bool ValidarDuplicados(string codigo)
        {
            bool resultadoBusquedaUsuario = false;

            resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: Log.Curso, codigo: codigo);

            return resultadoBusquedaUsuario;
        }


        // Valida duplicados de estudiante
        public static bool ValidarDuplicados(string legajo, string correo)
        {
            bool resultadoBusquedaUsuario = false;

            resultadoBusquedaUsuario = ComprobarExistenciaPrevia(modo: Log.Estudiante, correo: correo, legajo: legajo);

            return resultadoBusquedaUsuario;
        }

        // Muestra un mensaje segun el resultado
        //public static string MostrarMensajeSegunResultado(bool resultado)
        //{
        //    string mensajeADevolver = "OK";

        //    if (resultado)
        //    {
        //        mensajeADevolver = "DUPLICADO";
        //    }

        //    return mensajeADevolver;
        //}

        public static bool ComprobarExistenciaPrevia(Log modo, string correo = null, string codigo = null, string legajo = null)
        {
            bool resultadoBusquedaUsuario = false;
            //if (modo == Log.Admin)
            //{
            //    resultadoBusquedaUsuario = Sistema.BaseDatosAdministradores.BuscarUsuarioBD(correo);
            //}

            if (modo == Log.Curso)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosCursos.BuscarCursoBD(codigo);
            }
            else if (modo == Log.Estudiante)
            {
                resultadoBusquedaUsuario = Sistema.BaseDatosEstudiantes.BuscarUsuarioExistenteBD(correo, legajo);
            }

            return resultadoBusquedaUsuario;
        }
    }
}
