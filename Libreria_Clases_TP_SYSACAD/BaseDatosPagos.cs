using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD
{
    public class BaseDatosPagos
    {
        private List<RegistroDePago> _listaRegistrosPagos = new List<RegistroDePago>();

        internal BaseDatosPagos()
        {
            this._listaRegistrosPagos = ArchivosJSONPagos.CargarPagosDesdeArchivoJson();
        }

        public void IngresarNuevoPago(List<RegistroDePago> nuevosPagos)
        {
            try
            {
                if (nuevosPagos.Count > 0)
                {
                    foreach (RegistroDePago pago in nuevosPagos)
                    {
                        _listaRegistrosPagos.Add(pago);
                    }
                    ArchivosJSONPagos.GuardarArchivoJSON(_listaRegistrosPagos);
                }
            }
            catch (IOException ex)
            {
                // Manejo específico de excepciones de entrada/salida al guardar el archivo JSON.
                Console.WriteLine("Error al guardar el archivo JSON: " + ex.Message);
            }
        }

        public List<RegistroDePago> ObtenerIngresosSegunConceptoYFecha(DateTime fechaDesde, DateTime fechaHasta, ConceptoDePago concepto)
        {
            List<RegistroDePago> listaIngresosSegunConceptoYFecha = new List<RegistroDePago>();

            foreach (RegistroDePago registro in _listaRegistrosPagos)
            {
                if (registro.FechaPago >= fechaDesde && registro.FechaPago <= fechaHasta && registro.NombreConcepto == concepto.Nombre)
                {
                    listaIngresosSegunConceptoYFecha.Add(registro);
                }
            }

            return listaIngresosSegunConceptoYFecha;
        }
    }
}
