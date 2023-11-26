using Libreria_Clases_TP_SYSACAD.BaseDeDatos;
using Libreria_Clases_TP_SYSACAD.EntidadesSecundarias;
using Libreria_Clases_TP_SYSACAD.Gestores;
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
        private int _registrosTotales;
        private double _totalMontos;
        private BindingSource miBindingSource = new BindingSource();
        private GestorReportes gestorReportes = new GestorReportes();
        public FormReporteIngresosConceptoPago(string conceptoPago, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();

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

        /// <summary>
        /// Configura el enlace de datos entre una lista de registros de pago y un DataGridView mediante un BindingSource.
        /// </summary>
        private void ConfigurarBindingSourceRegistroDePago()
        {
            BindingList<RegistroDePago> bindingListaRegistroDePago = new BindingList<RegistroDePago>();

            // Asigna la BindingList<RegistroDePago> al BindingSource
            miBindingSource.DataSource = bindingListaRegistroDePago;

            // Enlaza el DataGridView al BindingSource
            registrosDePagoDGV.DataSource = miBindingSource;
        }

        /// <summary>
        /// Agrega una lista de registros de pago al origen de datos enlazado con el DataGridView de registros de pago.
        /// </summary>
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
