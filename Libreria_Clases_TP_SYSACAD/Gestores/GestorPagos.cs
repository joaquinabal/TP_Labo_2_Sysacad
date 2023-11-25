using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using Libreria_Clases_TP_SYSACAD.Validaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorPagos
    {
        public string ValidarMontoAAbonar(List<double> listaDeMontosAAbonar, List<double> listaDeMontosOriginales)
        {
            ValidadorMontoAAbonar validadorMontosAAbonar = new ValidadorMontoAAbonar(listaDeMontosAAbonar);
            ValidadorMontoAAbonar validadorMontosOriginales = new ValidadorMontoAAbonar(listaDeMontosAAbonar, listaDeMontosOriginales);

            bool numeroNegativo = validadorMontosAAbonar.VerificarSiHayNumeroNegativo();
            bool valorExcesivo = validadorMontosOriginales.VerificarSiHayValorExcesivo();

            string resultadoValidacion;

            if (numeroNegativo && valorExcesivo)
            {
                resultadoValidacion = "AMBOS MAL";
            }
            else if (numeroNegativo)
            {
                resultadoValidacion = "NEGATIVO";
            }
            else if (valorExcesivo)
            {
                resultadoValidacion = "EXCESIVO";
            }
            else
            {
                resultadoValidacion = "OK";
            }

            return resultadoValidacion;
        }

        public async Task<RespuestaValidacionInput> GestionarPago(Dictionary<string, string> camposIngresados, Dictionary<string, double> conceptosSeleccionados, DateTime fechaActual, ModoValidacionInput modo)
        {
            //RespuestaValidacionInput resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.MediosPagoTarjeta);
            RespuestaValidacionInput resultadoInputs = ValidarInputsPago(camposIngresados, modo);

            if (resultadoInputs.AusenciaCamposVacios && !resultadoInputs.ExistenciaErrores)
            {
                await Sistema.EstudianteLogueado.ActualizarConceptosDePago(conceptosSeleccionados);

                List<RegistroDePago> listaRegistrosPago = GenerarListaConNuevosRegistrosDePago(conceptosSeleccionados);

                await ConsultasPagos.IngresarNuevoPago(listaRegistrosPago);
            }

            return resultadoInputs;
        }

        private RespuestaValidacionInput ValidarInputsPago(Dictionary<string, string> camposIngresados, ModoValidacionInput modo)
        {
            ValidadorInputGenerico validacionDelInput = new ValidadorInputGenerico();
            RespuestaValidacionInput resultadoInputs;

            if (modo == ModoValidacionInput.MediosPagoTarjeta)
            {
                resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.MediosPagoTarjeta);
            }
            else
            {
                resultadoInputs = validacionDelInput.ValidarDatos(camposIngresados, ModoValidacionInput.MediosPagoTransferencia);
            }

            return resultadoInputs;
        }

        private List<RegistroDePago> GenerarListaConNuevosRegistrosDePago(Dictionary<string, double> conceptosSeleccionados)
        {
            List<RegistroDePago> listaRegistrosPago = new List<RegistroDePago>();

            foreach (KeyValuePair<string, double> kvp in conceptosSeleccionados)
            {
                string concepto = kvp.Key;
                double valor = kvp.Value;

                RegistroDePago nuevoRegistroDePago = new RegistroDePago(Sistema.EstudianteLogueado.Legajo, Sistema.EstudianteLogueado.Nombre, concepto, valor, DateTime.Now);
                listaRegistrosPago.Add(nuevoRegistroDePago);
            }

            return listaRegistrosPago;
        }
    }
}
