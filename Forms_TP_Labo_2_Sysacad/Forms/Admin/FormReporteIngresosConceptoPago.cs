using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.Entidades_Secundarias;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_TP_Labo_2_Sysacad.Forms.Admin
{
    public partial class FormReporteIngresosConceptoPago : FormPadre
    {
        private List<RegistroDePago> _listaRegistrosDePago;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private DateTime _fechaConMasRegistros;
        private string _concepto;
        private double _promedioInscripciones;
        private int _registrosTotales;
        private double _totalMontos;
        private BindingSource miBindingSource = new BindingSource();
        private bool _inscripcionFlag = false;
        private GestorReportes gestorReportes = new GestorReportes();
        public FormReporteIngresosConceptoPago(string conceptoPago, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();
            _inscripcionFlag = true;
            _concepto = conceptoPago;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _listaRegistrosDePago = gestorReportes.ObtenerIngresosPorConceptoPeriodo(_fechaDesde, _fechaHasta, _concepto);
            _fechaConMasRegistros = gestorReportes.CalcularFechaMasPopular(_listaRegistrosDePago);
            _registrosTotales = gestorReportes.CalcularRegistrosTotales(_listaRegistrosDePago);
            _totalMontos = gestorReportes.CalcularMontoIngresosTotales(_listaRegistrosDePago);
            desdeLabel.Text = $"Desde: {_fechaDesde}";
            hastaLabel.Text = $"Hasta: {_fechaHasta}";
            fechaPopularLabel.Text = $"Fecha con más registros: {_fechaConMasRegistros}";
            mediaPorDiaLabel.Text = $"Montos Totales: {_totalMontos}";
            inscripcionesTotalesLabel.Text = $"Registros Totales: {_registrosTotales}";
            ConfigurarBindingSourceRegistroDePago();
            MostrarInscripciones();
        }

        private void ConfigurarBindingSourceRegistroDePago()
        {
            BindingList<RegistroDePago> bindingListaRegistroDePago = new BindingList<RegistroDePago>();

            // Asigna la BindingList<RegistroDePago> al BindingSource
            miBindingSource.DataSource = bindingListaRegistroDePago;

            // Enlaza el DataGridView al BindingSource
            registrosDePagoDGV.DataSource = miBindingSource;
        }

        private void MostrarInscripciones()
        {
            // Obtenemos el BindingSource que enlaza el DataGridView
            BindingSource bindingSource = (BindingSource)registrosDePagoDGV.DataSource;

            // Obtenemos la BindingList<RegistroDeInscripcion> desde el BindingSource
            BindingList<RegistroDePago> bindingListaRegistroDePago = (BindingList<RegistroDePago>)bindingSource.List;


            foreach (RegistroDePago registroDePago in _listaRegistrosDePago)
            {
                bindingListaRegistroDePago.Add(registroDePago);
            }

        }

        public static DateTime GetFechaConMasInscripciones(List<RegistroDeInscripcion> listaInscripciones)
        {
            int maxInscripciones = 0;
            DateTime fechaConMasInscripciones = DateTime.MinValue;

            foreach (RegistroDeInscripcion inscripcion in listaInscripciones)
            {
                int inscripcionesEnFecha = 0;

                // Obtenemos la fecha de la inscripción
                DateTime fechaInscripcion = inscripcion.Fecha;

                // Obtenemos el día, mes y año de la inscripción
                int dia = fechaInscripcion.Day;
                int mes = fechaInscripcion.Month;
                int anio = fechaInscripcion.Year;

                // Contamos las inscripciones en la fecha actual
                foreach (RegistroDeInscripcion otraInscripcion in listaInscripciones)
                {
                    if (otraInscripcion.Fecha.Day == dia && otraInscripcion.Fecha.Month == mes && otraInscripcion.Fecha.Year == anio)
                    {
                        inscripcionesEnFecha++;
                    }
                }

                // Si el número de inscripciones en la fecha actual es mayor que el máximo, actualizamos el máximo y la fecha
                if (inscripcionesEnFecha > maxInscripciones)
                {
                    maxInscripciones = inscripcionesEnFecha;
                    fechaConMasInscripciones = fechaInscripcion;
                }
            }

            return fechaConMasInscripciones.Date;
        }

        private void ExportarPDFBtn_Click(object sender, EventArgs e)
        {
            string nombreArchivo = $"IngresoConceptoPago{DateTime.Now.ToString("yyyyMMddhhmm")}.PDF";
            GeneradorDePDF.GenerarPDFIngresos(nombreArchivo, _listaRegistrosDePago, _registrosTotales, _totalMontos, _fechaConMasRegistros, DateTime.Now.ToString("dd/MM/yyyy"), _fechaDesde.ToString("dd/MM/yyyy"), _fechaHasta.ToString("dd/MM/yyyy"));
            MessageBox.Show($"Se ha creado el reporte {nombreArchivo}.");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPanelReportes FormPanelReportes = new FormPanelReportes();
            FormPanelReportes.Show();
        }
    }
}
