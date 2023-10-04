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
        public RespuestaValidacionInput ValidarDatosMedioDePago(Dictionary<string, string> diccionarioConCampos, ModoPago modo)
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

        public override List<string> ValidarRegex(Dictionary<string, string> diccionarioConCamposIngresados, ModoPago modo)
        {
            List<string> listaErrores = new List<string>();

            if (modo == ModoPago.tarjeta)
            {
                // Validar el nombre 
                if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaErrores.Add("Nombre");
                }

                // Validar el número de tarjeta 
                if (!Regex.IsMatch(diccionarioConCamposIngresados["numero"], @"^\d{16}$"))
                {
                    listaErrores.Add("Numero de Tarjeta");
                }

                // Validar la fecha de vencimiento 
                if (!Regex.IsMatch(diccionarioConCamposIngresados["vencimiento"], @"^(0[1-9]|1[0-2])/\d{2}$"))
                {
                    listaErrores.Add("Fecha de Vencimiento");
                }

                // Validar el código de seguridad 
                if (!Regex.IsMatch(diccionarioConCamposIngresados["codigo"], @"^\d{3}$"))
                {
                    listaErrores.Add("Codigo de Seguridad");
                }
            }
            else if (modo == ModoPago.transferencia) 
            {
                // Validar el nombre 
                if (!Regex.IsMatch(diccionarioConCamposIngresados["nombre"], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaErrores.Add("Nombre");
                }

                // Validar el CBU
                if (!Regex.IsMatch(diccionarioConCamposIngresados["CBU"], @"^\d{22}$"))
                {
                    listaErrores.Add("CBU");
                }
            }

            return listaErrores;
        }
    }
}
