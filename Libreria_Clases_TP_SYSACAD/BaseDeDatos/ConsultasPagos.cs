using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using Libreria_Clases_TP_SYSACAD.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.BaseDeDatos
{
    public class ConsultasPagos : ConexionBD
    {
        private static List<RegistroDePago> _listaRegistrosPagos = new List<RegistroDePago>();

        ///////////////////RECONSTRUCCION DE LA LISTA DE PAGOS A PARTIR DE BD
        internal static void CrearInstanciasDePagosAPartirDeBD()
        {
            _listaRegistrosPagos.Clear();
            _listaRegistrosPagos = CargaDeInstanciasDesdeBD.CrearInstanciasDePagosAPartirDeBD();
        }

        //////////////////////CREATE
        public static async Task IngresarNuevoPago(List<RegistroDePago> nuevosPagos)
        {
            foreach (RegistroDePago registro in nuevosPagos)
            {
                string query = "INSERT INTO RegistroDePago (legajoEstudiante, conceptoNombre, ingreso, fechaPago) " +
                       "VALUES (@legajoEstudiante, @conceptoNombre, @ingreso, @fechaPago)";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@legajoEstudiante", registro.Legajo },
                    { "@conceptoNombre", registro.Concepto },
                    { "@ingreso", registro.Ingreso },
                    { "@fechaPago", DateTime.Now }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }

            CrearInstanciasDePagosAPartirDeBD();
        }

        //////////////////////READ
        public static List<RegistroDePago> ObtenerIngresosSegunConceptoYFecha(DateTime fechaDesde, DateTime fechaHasta, string concepto)
        {
            List<RegistroDePago> listaIngresosSegunConceptoYFecha = new List<RegistroDePago>();

            foreach (RegistroDePago registro in _listaRegistrosPagos)
            {
                if (registro.Fecha >= fechaDesde && registro.Fecha <= fechaHasta && registro.Concepto == concepto)
                {
                    listaIngresosSegunConceptoYFecha.Add(registro);
                }
            }

            return listaIngresosSegunConceptoYFecha;
        }

        /////////////////////UPDATE
        public static async Task ActualizarConceptosDePagoDeEstudiante(Dictionary<string, double> listaConceptosPagados, string legajo)
        {
            foreach (var parKeyValue in listaConceptosPagados)
            {
                string query = "UPDATE ConceptosDePagoDeEstudiante SET montoPendiente = montoPendiente - @montoPagado " +
                       "WHERE legajoEstudiante = @legajo and conceptoNombre = @conceptoPago";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@montoPagado", parKeyValue.Value },
                    { "@legajo", legajo },
                    { "@conceptoPago", parKeyValue.Key }
                };

                await ConsultasGenericas.EjecutarNonQuery(query, parametros);
            }

            RefrescarEstudianteLogueado();
        }

        ///////// REFRESCAR ESTUDIANTE LOGUEADO
        private static void RefrescarEstudianteLogueado()
        {
            ConsultasEstudiantes.CrearInstanciasDeEstudiantesAPartirDeBD();
            Sistema.IngresarEstudianteComoUsuarioActivo(Sistema.CorreoEstudianteLogueado);
        }

        //Getters y Setters
        public static List<RegistroDePago> Pagos { get { return _listaRegistrosPagos; } }
    }
}
