using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorInputCursos : ValidadorInputs
    {
        /// <summary>
        /// Valida los datos de un curso a partir de un diccionario de campos.
        /// </summary>
        /// <param name="diccionarioConCampos">Diccionario con los campos a validar.</param>
        /// <returns>Una instancia de <see cref="RespuestaValidacionInput"/> que contiene el resultado de la validación.</returns>
        public RespuestaValidacionInput ValidarDatosCurso(Dictionary<string, string> diccionarioConCampos)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
            List<string> listaErrores = ValidarRegex(diccionarioConCampos);

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores ,listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        /// <summary>
        /// Valida datos específicos del curso utilizando expresiones regulares.
        /// </summary>
        /// <param name="diccionarioConCamposIngresados">Diccionario con campos de datos de cursos.</param>
        /// <returns>Una lista de mensajes de error para los campos que no cumplen con las expresiones regulares.</returns>
        public override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados)
        {
            List<string> listaErrores = new List<string>();
            
            // Valida el nombre de la MATERIA (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[a-zA-Z0-9\s]+$"))
            {
                listaErrores.Add("Nombre de la materia");
            }

            // Valida el codigo (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["codigo"], @"^[a-zA-Z0-9]+$"))
            {
                listaErrores.Add("Codigo");
            }

            // Valida el numero de aula (3 digitos)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["aula"], @"^\d{3}$"))
            {
                listaErrores.Add("Número de Aula");
            }

            // Valida la descripcion (Alfanumerico)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["descripcion"], @"^[a-zA-Z0-9ñÑ°\s.,-]+$"))
            {
                listaErrores.Add("Descripcion");
            }

            // Valida el cupo maximo (Solo digitos)
            if (!Regex.IsMatch(diccionarioConCamposIngresados["cupoMax"], @"^[0-9]+$"))
            {
                listaErrores.Add("Cupo maximo");
            }

            return listaErrores;
        }

    }
}
