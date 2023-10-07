using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public enum ModoPago { tarjeta, transferencia}

    public class ValidadorInputMediosPago : ValidadorInputs
    {
        /// <summary>
        /// Valida los datos de un medio de pago según el modo especificado (tarjeta o transferencia).
        /// </summary>
        /// <param name="diccionarioConCampos">Diccionario que contiene los campos a validar.</param>
        /// <param name="modo">Modo de pago a validar (ModoPago.Tarjeta o ModoPago.Transferencia).</param>
        /// <returns>Una instancia de RespuestaValidacionInput que contiene los resultados de la validación.</returns>
        public RespuestaValidacionInput ValidarDatosMedioDePago (Dictionary<string, string> diccionarioConCampos, ModoPago modo)
        {
            //Recibo el diccionario y meto sus valores a una lista
            List<string> listaCamposIngresados = ObtenerListaDeCamposDesdeDiccionario(diccionarioConCampos);

            //Valido si no hay campos vacios. Si todo esta bien devuelve true
            bool resultadoCamposVacios = ValidarCampos(listaCamposIngresados);

            //Valido que cumplan el regex. Si esta todo bien devuelve una lista vacia
            List<string> listaErrores = new List<string>();
            listaErrores = ValidarRegex(diccionarioConCampos, modo);

            //Compruebo si la lista de errores esta efectivamente vacia
            bool resultadoExistenciaErrores = ComprobarExistenciaErrores(listaErrores);

            //Creo una nueva instancia de clase RESPUESTA VALIDACION.
            RespuestaValidacionInput respuestaValidacion = new RespuestaValidacionInput(resultadoCamposVacios, resultadoExistenciaErrores, listaErrores);

            //Devuelvo la respuesta
            return respuestaValidacion;
        }

        /// <summary>
        /// Valida los campos del diccionario según el modo especificado.
        /// </summary>
        /// <param name="diccionarioConCamposIngresados">Diccionario que contiene los campos a validar.</param>
        /// <param name="modo">Modo de pago a validar (ModoPago.Tarjeta o ModoPago.Transferencia).</param>
        /// <returns>Una lista de cadenas que representan los errores de validación encontrados.</returns>
        public override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoPago modo)
        {
            List<string> listaErrores = new List<string>();

            if (modo == ModoPago.tarjeta)
            {
                // Valida el nombre (Alfanumerico)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaErrores.Add("Nombre");
                }

                // Valida el número de tarjeta (16 digitos)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["numero"], @"^\d{16}$"))
                {
                    listaErrores.Add("Numero de Tarjeta");
                }

                // Valida la fecha de vencimiento (Formato MM/YY)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["vencimiento"], @"^(0[1-9]|1[0-2])/\d{2}$"))
                {
                    listaErrores.Add("Fecha de Vencimiento");
                }

                // Valida el código de seguridad (3 digitos)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["codigo"], @"^\d{3}$"))
                {
                    listaErrores.Add("Codigo de Seguridad");
                }
            }
            else if (modo == ModoPago.transferencia) 
            {
                // Valida el nombre (Alfanumerico)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaErrores.Add("Nombre");
                }

                // Valida el CBU (22 digitos)
                if (!Regex.IsMatch(diccionarioConCamposIngresados["CBU"], @"^\d{22}$"))
                {
                    listaErrores.Add("CBU");
                }
            }

            return listaErrores;
        }
    }
}
