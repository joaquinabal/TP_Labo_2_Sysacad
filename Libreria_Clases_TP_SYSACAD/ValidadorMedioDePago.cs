using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class ValidadorMedioDePago : Validador
    {
        public string ValidarTarjetas(List<string> listaDeCamposIngresados)
        {
            bool resultadoValidacionCampos = ValidarCampos(listaDeCamposIngresados);

            string mensajeADevolver = string.Empty;

            List<string> listaDeErrores = new List<string>();

            if (resultadoValidacionCampos)
            {
                // Validar el nombre 
                if (!Regex.IsMatch(listaDeCamposIngresados[0], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaDeErrores.Add("Nombre");
                }

                // Validar el número de tarjeta 
                if (!Regex.IsMatch(listaDeCamposIngresados[1], @"^\d{16}$"))
                {
                    listaDeErrores.Add("Numero de Tarjeta");
                }

                // Validar la fecha de vencimiento 
                if (!Regex.IsMatch(listaDeCamposIngresados[2], @"^(0[1-9]|1[0-2])/\d{2}$"))
                {
                    listaDeErrores.Add("Fecha de Vencimiento");
                }

                // Validar el código de seguridad 
                if (!Regex.IsMatch(listaDeCamposIngresados[3], @"^\d{3}$"))
                {
                    listaDeErrores.Add("Codigo de Seguridad");
                }

                if (listaDeErrores.Count > 0)
                {
                    mensajeADevolver = "Debe corregir: \n";
                    foreach (string error in listaDeErrores)
                    {
                        mensajeADevolver += $"{error} \n";
                    }
                }
                else
                {
                    mensajeADevolver = "OK";
                }
            }
            else
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }

            return mensajeADevolver;
        }

        public string ValidarTransferencia(List<string> listaDeCamposIngresados)
        {
            bool resultadoValidacionCampos = ValidarCampos(listaDeCamposIngresados);

            string mensajeADevolver = string.Empty;

            List<string> listaDeErrores = new List<string>();

            if (resultadoValidacionCampos)
            {
                // Validar el nombre 
                if (!Regex.IsMatch(listaDeCamposIngresados[0], @"^[A-Za-z]+\s[A-Za-z]+$"))
                {
                    listaDeErrores.Add("Nombre");
                }

                // Validar el CBU
                if (!Regex.IsMatch(listaDeCamposIngresados[1], @"^\d{22}$"))
                {
                    listaDeErrores.Add("CBU");
                }

                if (listaDeErrores.Count > 0)
                {
                    mensajeADevolver = "Debe corregir: \n";
                    foreach (string error in listaDeErrores)
                    {
                        mensajeADevolver += $"{error} \n";
                    }
                }
                else
                {
                    mensajeADevolver = "OK";
                }
            }
            else
            {
                mensajeADevolver = "CAMPOS VACIOS";
            }

            return mensajeADevolver;
        }

    }
}
