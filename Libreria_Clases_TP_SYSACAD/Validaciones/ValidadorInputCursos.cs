using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Validaciones
{
    public enum ModoValidacionInputCurso
    {
        AgregarOEditar,
        Requisitos
    }

    public class ValidadorInputCursos : ValidadorInputs
    {
        /// <summary>
        /// Valida los datos de un curso a partir de un diccionario de campos.
        /// </summary>
        /// <param name="diccionarioConCampos">Diccionario con los campos a validar.</param>
        /// <returns>Una instancia de <see cref="RespuestaValidacionInput"/> que contiene el resultado de la validación.</returns>
        public RespuestaValidacionInput ValidarDatosCurso(Dictionary<string, string> diccionarioConCampos, ModoValidacionInputCurso modo)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);
            List<string> listaErrores = new List<string>();

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            if (resultadoCamposVacios)
            {
                //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
                listaErrores = ValidarRegex(diccionarioConCampos, modo);
            }

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores, listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        /// <summary>
        /// Valida datos específicos del curso utilizando expresiones regulares.
        /// </summary>
        /// <param name="diccionarioConCamposIngresados">Diccionario con campos de datos de cursos.</param>
        /// <returns>Una lista de mensajes de error para los campos que no cumplen con las expresiones regulares.</returns>
        protected override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoValidacionInputCurso modo)
        {
            List<string> listaErrores = new List<string>();

            if (modo == ModoValidacionInputCurso.AgregarOEditar)
            {
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
            }
            else if (modo == ModoValidacionInputCurso.Requisitos)
            {
                // Valida los creditos (Solo numeros del 0 al 1000)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["creditos"], @"^(1000|\d{1,3})$"))
                {
                    listaErrores.Add("Creditos");
                }

                // Valida el promedio (Solo numeros del 0 al 10. Pueden haber puntos para el decimal)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["promedio"], @"^(10|\d(\.\d{1,2})?)$"))
                {
                    listaErrores.Add("Promedio");
                }
            }

            return listaErrores;
        }

    }
}
