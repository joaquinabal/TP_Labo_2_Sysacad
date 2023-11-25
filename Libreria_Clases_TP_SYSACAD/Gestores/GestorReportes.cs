using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesPrimarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Interfaces_y_Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Clases_TP_SYSACAD.Gestores
{
    public class GestorReportes //CLASE INTERMEDIA ENTRE FORMS Y LAS CONSULTAS/ESTADISTICAS
    {
        private ConsultasInscripciones _consultasInscripciones = new ConsultasInscripciones();
        private ConsultasPagos _consultasPagos = new ConsultasPagos();
        private ConsultasCursos _consultasCursos = new ConsultasCursos();
        private EstadisticasReportes _generadorDeEstadisticas = new EstadisticasReportes();

        /////////////////////////////// METODOS PARA OBTENER LOS REGISTROS ////////////////////////////////

        public List<RegistroDeInscripcion> ObtenerInscripcionesPorCursoPeriodo(DateTime fechaDesde, DateTime fechaHasta, string codigoCurso)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta, codigoCurso);
        }

        public List<RegistroDeInscripcion> ObtenerInscripcionesPorCarreraPeriodo(DateTime fechaDesde, DateTime fechaHasta, Carrera carrera)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta, carrera);
        }

        public List<RegistroDePago> ObtenerIngresosPorConceptoPeriodo(DateTime fechaDesde, DateTime fechaHasta, string conceptoPago)
        {
            return _consultasPagos.ObtenerIngresosSegunConceptoYFecha(fechaDesde, fechaHasta, conceptoPago);
        }

        public List<RegistroDeInscripcion> ObtenerInscripcionesTotalesPorPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _consultasInscripciones.ObtenerInscripciones(fechaDesde, fechaHasta);
        }

        public Dictionary<Curso, Dictionary<string, DateTime>> ObtenerCursosConListaDeEsperaSegunFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _consultasCursos.DevolverDiccionarioConRegistrosListaDeEsperaSegunFechas(fechaDesde, fechaHasta);
        }

        /////////////////////////////// METODOS PARA OBTENER LAS ESTADISTICAS ////////////////////////////////

        public int CalcularRegistrosTotales<T>(List<T> listaRegistrosMostrados) where T : IRegistroEstadistico
        {
            return _generadorDeEstadisticas.CalcularRegistrosTotales(listaRegistrosMostrados);
        }

        public double CalcularMontoIngresosTotales(List<RegistroDePago> listaRegistrosMostrados)
        {
            return _generadorDeEstadisticas.CalcularMontoIngresosTotales(listaRegistrosMostrados);
        }

        public DateTime CalcularFechaMasPopular<T>(List<T> listaRegistrosMostrados) where T : IRegistroEstadistico
        {
            return _generadorDeEstadisticas.CalcularFechaMasPopular(listaRegistrosMostrados);
        }

        public double CalcularMediaPorDia(List<RegistroDeInscripcion> listaRegistrosMostrados)
        {
            return _generadorDeEstadisticas.CalcularMediaPorDia(listaRegistrosMostrados);
        }
    }
}
